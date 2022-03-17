using InfSec.User;
using System;
using System.Windows.Forms;

namespace InfSec
{
    public partial class FormRegister : Form
    {
        UserMethods methods;

        public FormRegister(UserMethods methods)
        {
            InitializeComponent();
            this.methods = methods;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Необходимо ввести логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                methods.Register(textBoxLogin.Text);
                MessageBox.Show("Успешно создан новый аккаунт", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
