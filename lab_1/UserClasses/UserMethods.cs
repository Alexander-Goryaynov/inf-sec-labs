using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace InfSec.User
{
    public class UserMethods
    {
        public List<UserBindingModel> Users { get; private set; }
        private readonly SaveManager saveClass;

        public UserMethods(string passPhrase)
        {
            try
            {
                saveClass = new SaveManager(passPhrase);
                Users = saveClass.Users;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Register(string login)
        {
            UserBindingModel user = Users.FirstOrDefault(u => u.Login == login);
            if (user != null)
            {
                throw new Exception("Логин уже используется");
            }
            Users.Add(new UserBindingModel
            {
                Block = false,
                PasswordLimit = false,
                EnteringFirst = true,
                Login = login,
                Password = null
            });
        }

        public UserViewModel GetUser(string login)
        {
            UserBindingModel user = Users.FirstOrDefault(u => u.Login == login);
            return new UserViewModel
            {
                Login = user.Login,
                Block = user.Block,
                PasswordLimit = user.PasswordLimit,
                EnteringFirst = user.EnteringFirst
            };
        }

        public UserViewModel Authorization(string login, string password)
        {
            UserBindingModel user = Users.FirstOrDefault(u => u.Login == login);
            if (user == null)
                throw new Exception("Пользователь не существует");
            if (user.EnteringFirst && (password != "" || password != null))
                throw new Exception("Пароль отсутствует. Для первого входа оставьте поле \"Пароль\" пустым");
            else if (user.Password != saveClass.GetHash(password))
                throw new Exception("Неверный пароль");
            return new UserViewModel
            {
                Login = user.Login,
                Block = user.Block,
                PasswordLimit = user.PasswordLimit,
                EnteringFirst = user.EnteringFirst
            };
        }

        public void BlockUser(string login)
        {
            UserBindingModel user = Users.FirstOrDefault(u => u.Login == login);
            if (user == null)
                throw new Exception("Пользователь не найден");
            user.Block = !user.Block;
        }

        public void SetLimit(string login)
        {
            UserBindingModel user = Users.FirstOrDefault(u => u.Login == login);
            if (user == null)
                throw new Exception("Пользователь не найден");
            user.PasswordLimit = !user.PasswordLimit;
        }

        public void ChangePassword(UserBindingModel user, string password, string new_password)
        {
            if (user == null)
                throw new Exception("Пользователь не найден");
            if (password != "" || password == null)
                if (user.Password != saveClass.GetHash(password))
                    throw new Exception("Неверный пароль");
            if (new_password == password)
                throw new Exception("Пароль совпадает со старым");
            if (user.PasswordLimit == true)
                if (!CheckPasswordLimited(new_password))
                    throw new Exception("Пароль должен содержать буквы и знаки арифметических операций");
            user.Password = saveClass.GetHash(new_password);
        }

        // Вариант 6. Наличие букв и знаков арифметических операций
        public bool CheckPasswordLimited(string password)
        {
            if (!Regex.IsMatch(password, @"[\w]"))
                return false;
            if (!Regex.IsMatch(password, @"[\-+/*=]"))
                return false;
            return true;
        }

        public List<UserViewModel> GetUsers()
        {
            return Users.Where(u => u.Login != "ADMIN")
                .Select(u => new UserViewModel
                {
                    Login = u.Login,
                    Block = u.Block,
                    PasswordLimit = u.PasswordLimit
                }).ToList();
        }

        public void SaveUsers()
        {
            saveClass.Save(Users);
        }
    }
}
