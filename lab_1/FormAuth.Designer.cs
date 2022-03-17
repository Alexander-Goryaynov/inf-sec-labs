using System.Windows.Forms;

namespace InfSec
{
    partial class FormAuth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(3, 0);
            this.lblLogin.Name = "label1";
            this.lblLogin.Padding = new System.Windows.Forms.Padding(4);
            this.lblLogin.Size = new System.Drawing.Size(55, 24);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Логин";
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(3, 77);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.lblPassword.Name = "label2";
            this.lblPassword.Padding = new System.Windows.Forms.Padding(4);
            this.lblPassword.Size = new System.Drawing.Size(65, 24);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Пароль";
            this.textBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxLogin.Location = new System.Drawing.Point(3, 34);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBoxLogin.Name = "loginTextBox";
            this.textBoxLogin.Size = new System.Drawing.Size(236, 20);
            this.textBoxLogin.TabIndex = 2;
            this.textBoxPassword.Location = new System.Drawing.Point(3, 111);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBoxPassword.Name = "passwordTextBox";
            this.textBoxPassword.Size = new System.Drawing.Size(236, 20);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirm.Location = new System.Drawing.Point(80, 154);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnConfirm.Name = "EnterButton";
            this.btnConfirm.Size = new System.Drawing.Size(81, 36);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Вход";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(51, 196);
            this.btnClose.Name = "CloseButton";
            this.btnClose.Size = new System.Drawing.Size(139, 36);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Завершить работу";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.lblLogin);
            this.flowLayoutPanel1.Controls.Add(this.textBoxLogin);
            this.flowLayoutPanel1.Controls.Add(this.lblPassword);
            this.flowLayoutPanel1.Controls.Add(this.textBoxPassword);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Controls.Add(this.btnClose);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(246, 239);
            this.flowLayoutPanel1.TabIndex = 6;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AutorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAuth_FormClosed);
            this.Shown += new System.EventHandler(this.FormAuth_Shown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

            this.flowLayoutPanel1.Location = new System.Drawing.Point(ClientSize.Width / 2 - 246 / 2, ClientSize.Height / 2 - 239 / 2);

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

