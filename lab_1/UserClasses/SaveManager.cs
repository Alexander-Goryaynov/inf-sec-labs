using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;
using System;
using System.Linq;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;
using System.Diagnostics;

namespace InfSec.User
{
    public class SaveManager
    {
        private readonly string path = "credentials.xml";
        private DESCryptoServiceProvider des;
        public List<UserBindingModel> Users { get; private set; }

        // Вариант 6. 
        // Используемый режим шифрования алгоритма DES: CBC. 
        // Добавление к ключу случайного значения: нет.
        public SaveManager(string passPhrase)
        {
            if (des == null)
            {
                try
                {
                    des = new DESCryptoServiceProvider
                    {
                        Mode = CipherMode.CBC
                    };
                    // Генерируем ключ
                    byte[] arr = Encoding.UTF8.GetBytes(passPhrase).ToList().Take(8).ToArray();
                    des.Key = arr;
                    //Случайное значение не добавляем
                    des.IV = arr;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            if (!File.Exists(path))
            {
                Users = new List<UserBindingModel>();
                UserBindingModel admin = new UserBindingModel
                {
                    Login = "ADMIN",
                    Password = null,
                    EnteringFirst = true,
                    Block = false,
                    PasswordLimit = true
                };
                Users.Add(admin);
            }
            else
                Users = Load();
        }

        // Вариант 6. Алгоритм хеширования: SHA
        public string GetHash(string input)
        {
            var bytes = Encoding.ASCII.GetBytes(input);
            var sha = SHA256.Create();
            var hashBytes = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }

        public void Save(List<UserBindingModel> list)
        {
            var xmlSerializer = new XmlSerializer(typeof(List<UserBindingModel>));
            var stringWriter = new StringWriter();
            xmlSerializer.Serialize(stringWriter, list);
            string xml = stringWriter.ToString();
            File.WriteAllText(path, Encrypt(xml));
        }

        public List<UserBindingModel> Load()
        {
            if (!File.Exists(path))
                throw new FileNotFoundException();
            var xmlSerializer = new XmlSerializer(typeof(List<UserBindingModel>));
            var xml = Decrypt(File.ReadAllText(path));
            Debug.WriteLine(xml);
            using (TextReader reader = new StringReader(xml))
            {
                return (List<UserBindingModel>)xmlSerializer.Deserialize(reader);
            }
        }

        public string Encrypt(string originalString)
        {
            if (string.IsNullOrEmpty(originalString))
            {
                throw new ArgumentNullException
                       ("Невозможно зашифровать пустую строку");
            }
            var memoryStream = new MemoryStream();
            var cryptoStream = new CryptoStream(memoryStream, des.CreateEncryptor(des.Key, des.IV), CryptoStreamMode.Write);
            var writer = new StreamWriter(cryptoStream);
            writer.Write(originalString);
            writer.Flush();
            cryptoStream.FlushFinalBlock();
            writer.Flush();
            return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
        }

        public string Decrypt(string cryptedString)
        {
            if (string.IsNullOrEmpty(cryptedString))
            {
                throw new ArgumentNullException
                   ("Невозможно расшифровать пустую строку");
            }
            MemoryStream memoryStream = new MemoryStream
                    (Convert.FromBase64String(cryptedString));
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                des.CreateDecryptor(des.Key, des.IV), CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cryptoStream);
            return reader.ReadToEnd();
        }
    }
}
