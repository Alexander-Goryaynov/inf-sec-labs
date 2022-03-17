using InfSec.User;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace InfSec
{
    public partial class FormAuth : Form
    {
        UserMethods methods;
        private int attempts = 3;

        public FormAuth()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (attempts < 1)
            {
                MessageBox.Show("Истёк лимит попыток авторизации", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Необходимо ввести логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                attempts--;
                return;
            }
            try
            {
                UserViewModel user = methods.GetUser(textBoxLogin.Text);
                if (user.Block == true)
                {
                    MessageBox.Show("Аккаунт заблокирован администратором", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    attempts--;
                    return;
                }
                if (string.IsNullOrEmpty(textBoxPassword.Text))
                {
                    if (user.EnteringFirst)
                    {
                        var form = new FormUpdatePassword(user.Login, methods);
                        form.ShowDialog();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Необходимо ввести пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        attempts--;
                        return;
                    }
                }
                user = methods.Authorization(textBoxLogin.Text, textBoxPassword.Text);
                new FormMenu(user.Login, methods).ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                attempts--;
                return;
            }
            textBoxLogin.Text = null;
            textBoxPassword.Text = null;
        }

        private void FormAuth_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (methods != null)
                methods.SaveUsers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormAuth_Shown(object sender, EventArgs e)
        {
            var passForm = new FormPasswordPhrase();
            passForm.ShowDialog();
            if (passForm.DialogResult != DialogResult.OK || passForm.passPhrase == "")
            {
                MessageBox.Show("Введите парольную фразу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            try
            {
                methods = new UserMethods(passForm.passPhrase);
                if (methods.Users.FirstOrDefault(u => u.Login == "ADMIN") == null)
                {
                    MessageBox.Show("Неверная парольная фраза", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    return;
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Неверная парольная фраза", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
        }
    }
}
