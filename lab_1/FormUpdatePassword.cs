using InfSec.User;
using System;
using System.Linq;
using System.Windows.Forms;

namespace InfSec
{
    public partial class FormUpdatePassword : Form
    {
        UserMethods methods;
        private readonly UserBindingModel user;

        public FormUpdatePassword(string login, UserMethods methods)
        {
            InitializeComponent();
            this.methods = methods;
            try
            {
                user = methods.Users.FirstOrDefault(u => u.Login == login);
            }
            catch (Exception)
            {
                MessageBox.Show("Аккаунт не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (user.EnteringFirst)
            {
                textBoxOldPassword.Visible = false;
                lblOld.Visible = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxOldPassword.Text) && !user.EnteringFirst)
            {
                MessageBox.Show("Необходимо ввести старый пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxNewPassword.Text))
            {
                MessageBox.Show("Необходимо ввести новый пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxNewPassword.Text != textBoxRepeatPassword.Text)
            {
                MessageBox.Show("Пароль и его подтверждение не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                methods.ChangePassword(user, textBoxOldPassword.Text, textBoxNewPassword.Text);
                user.EnteringFirst = false;
                MessageBox.Show("Изменение сохранено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
