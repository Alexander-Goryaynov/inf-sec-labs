using InfSec.User;
using System;
using System.Windows.Forms;

namespace InfSec
{
    public partial class FormMenu : Form
    {
        UserMethods methods;
        private string login;

        public FormMenu(string login, UserMethods methods)
        {
            InitializeComponent();
            this.methods = methods;
            this.login = login;
            BackColor = System.Drawing.Color.FromArgb(255, 192, 192);
            if (login != "ADMIN")
            {
                BackColor = System.Drawing.Color.FromArgb(192, 255, 255);
                btnShowUsers.Visible = false;
                btnShowUsers.Enabled = false;
            }
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            new FormUsers(methods).ShowDialog();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            new FormUpdatePassword(login, methods).ShowDialog();
        }

        private void btnShowStudentInfo_Click(object sender, EventArgs e)
        {
            new FormAboutStudent().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
