using System.Windows.Forms;

namespace InfSec
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.btnShowStudentInfo = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            this.btnShowUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowUsers.Location = new System.Drawing.Point(2, 2);
            this.btnShowUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowUsers.Name = "UsersButton";
            this.btnShowUsers.Size = new System.Drawing.Size(160, 29);
            this.btnShowUsers.TabIndex = 0;
            this.btnShowUsers.Text = "Пользователи";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            this.btnUpdatePassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdatePassword.Location = new System.Drawing.Point(264, 2);
            this.btnUpdatePassword.Margin = new System.Windows.Forms.Padding(100, 2, 2, 2);
            this.btnUpdatePassword.Name = "ChangePasswordButton";
            this.btnUpdatePassword.Size = new System.Drawing.Size(160, 29);
            this.btnUpdatePassword.TabIndex = 1;
            this.btnUpdatePassword.Text = "Изменить пароль";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            this.btnShowStudentInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowStudentInfo.Location = new System.Drawing.Point(526, 2);
            this.btnShowStudentInfo.Margin = new System.Windows.Forms.Padding(100, 2, 2, 2);
            this.btnShowStudentInfo.Name = "AboutButton";
            this.btnShowStudentInfo.Size = new System.Drawing.Size(160, 29);
            this.btnShowStudentInfo.TabIndex = 2;
            this.btnShowStudentInfo.Text = "О программе";
            this.btnShowStudentInfo.UseVisualStyleBackColor = true;
            this.btnShowStudentInfo.Click += new System.EventHandler(this.btnShowStudentInfo_Click);
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "UnlogButton";
            this.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogout.Size = new System.Drawing.Size(160, 29);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Выход";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.btnShowUsers);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdatePassword);
            this.flowLayoutPanel1.Controls.Add(this.btnShowStudentInfo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(130, 192);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(692, 38);
            this.flowLayoutPanel1.TabIndex = 4;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnLogout);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

            this.flowLayoutPanel1.Location = new System.Drawing.Point(ClientSize.Width / 2 - 692 / 2, ClientSize.Height / 2 - 38 / 2);
            this.btnLogout.Location = new System.Drawing.Point(ClientSize.Width - 30 - 160, 10);
        }

        #endregion

        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnShowStudentInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}