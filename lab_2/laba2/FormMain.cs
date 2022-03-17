using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace laba2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonOpenInputFile_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxInputFile.Text = openFileDialog.FileName;
            }
        }

        private void ButtonOpenEncryptedFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = null;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxEncryptFile.Text = saveFileDialog.FileName;
            }
        }

        private void ButtonOpenDecryptedFyle_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = null;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxDecryptFile.Text = saveFileDialog.FileName;
            }
        }

        private void ButtonOpenPasswordFile_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPasswordFile.Text = openFileDialog.FileName;
            }
        }

        private void RadioButtonPassword_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordTextBoxes();
        }

        private void RadioButtonPasswordFile_CheckedChanged(object sender, EventArgs e)
        {
            TogglePasswordTextBoxes();
        }

        private void TogglePasswordTextBoxes()
        {
            buttonOpenPasswordFile.Enabled = radioButtonPasswordFile.Checked;
            textBoxPassword.Enabled = radioButtonPassword.Checked;
            textBoxPassword.ReadOnly = !radioButtonPassword.Checked;
        }

        private void ButtonEncrypt_Click(object sender, EventArgs e)
        {
            string sourceFile = textBoxInputFile.Text;
            if (string.IsNullOrEmpty(sourceFile))
            {
                MessageBox.Show(this, "Не выбран исходный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string encodedFile = textBoxEncryptFile.Text;
            if (string.IsNullOrEmpty(encodedFile))
            {
                MessageBox.Show(this, "Не выбран зашифрованный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string password = ExtractPassword();
            if (password == null)
            {
                return;
            }
            ECB ecb = new ECB();
            ecb.Encrypt(sourceFile, encodedFile, password);
            Process.Start(encodedFile);
            MessageBox.Show(this, "Файл зашифрован", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonDecrypt_Click(object sender, EventArgs e)
        {
            string encodedFile = textBoxEncryptFile.Text;
            if (string.IsNullOrEmpty(encodedFile))
            {
                MessageBox.Show(this, "Не выбран зашифрованный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string decodedFile = textBoxDecryptFile.Text;
            if (string.IsNullOrEmpty(decodedFile))
            {
                MessageBox.Show(this, "Не выбран расшифрованный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string password = ExtractPassword();
            if (password == null)
            {
                return;
            }
            ECB ecb = new ECB();
            ecb.Decrypt(encodedFile, decodedFile, password);
            
            Process.Start(decodedFile);

            MessageBox.Show(this, "Файл расшифрован", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string ExtractPassword()
        {
            string password;
            if (radioButtonPassword.Checked)
            {
                password = textBoxPassword.Text;
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show(this, "Не указан пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            else
            {
                string passwordFile = textBoxPasswordFile.Text;
                if (string.IsNullOrEmpty(passwordFile))
                {
                    MessageBox.Show(this, "Не выбран файл с паролем", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                try
                {
                    password = File.ReadAllText(passwordFile, Encoding.UTF8);
                }
                catch (Exception e)
                {
                    MessageBox.Show(this, "Ошибка загрузки пароля из файла:\n" + e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show(this, "В файле не указан пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            return password;
        }
    }
}
