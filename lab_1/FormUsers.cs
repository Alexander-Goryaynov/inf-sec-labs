using InfSec.User;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InfSec
{
    public partial class FormUsers : Form
    {
        UserMethods methods;

        public FormUsers(UserMethods methods)
        {
            InitializeComponent();
            this.methods = methods;
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                List<UserViewModel> users = methods.GetUsers();
                dataGridUsers.DataSource = users;
                dataGridUsers.Columns[0].HeaderText = "Логин";
                dataGridUsers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridUsers.Columns[1].HeaderText = "Заблокировать";
                dataGridUsers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridUsers.Columns[2].HeaderText = "Ограничения пароля";
                dataGridUsers.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridUsers.Columns[3].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            new FormRegister(methods).ShowDialog();
            LoadUsers();
        }

        private void FormUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            methods.SaveUsers();
        }

        private void dataGridUsers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                if (e.ColumnIndex == 1)
                {
                    try
                    {
                        methods.BlockUser(dataGridUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
                        LoadUsers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (e.ColumnIndex == 2)
                {
                    try
                    {
                        methods.SetLimit(dataGridUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
                        LoadUsers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ActiveControl = btnNewUser;
        }
    }
}
