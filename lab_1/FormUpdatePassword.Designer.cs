using System.Windows.Forms;

namespace InfSec
{
    partial class FormUpdatePassword
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
            this.lblOld = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            this.lblOld.AutoSize = true;
            this.lblOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOld.Location = new System.Drawing.Point(3, 0);
            this.lblOld.Name = "labelOldPassword";
            this.lblOld.Padding = new System.Windows.Forms.Padding(4);
            this.lblOld.Size = new System.Drawing.Size(115, 24);
            this.lblOld.TabIndex = 0;
            this.lblOld.Text = "Старый пароль";
            this.lblNew.AutoSize = true;
            this.lblNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNew.Location = new System.Drawing.Point(3, 70);
            this.lblNew.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.lblNew.Name = "label2";
            this.lblNew.Padding = new System.Windows.Forms.Padding(4);
            this.lblNew.Size = new System.Drawing.Size(109, 24);
            this.lblNew.TabIndex = 1;
            this.lblNew.Text = "Новый пароль";
            this.textBoxOldPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxOldPassword.Location = new System.Drawing.Point(3, 27);
            this.textBoxOldPassword.Name = "oldPasswordTextBox";
            this.textBoxOldPassword.Size = new System.Drawing.Size(236, 20);
            this.textBoxOldPassword.TabIndex = 2;
            this.textBoxOldPassword.UseSystemPasswordChar = true;
            this.textBoxNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNewPassword.Location = new System.Drawing.Point(3, 97);
            this.textBoxNewPassword.Name = "newPasswordTextBox";
            this.textBoxNewPassword.Size = new System.Drawing.Size(236, 20);
            this.textBoxNewPassword.TabIndex = 3;
            this.textBoxNewPassword.UseSystemPasswordChar = true;
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirm.Location = new System.Drawing.Point(76, 210);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.btnConfirm.Name = "SaveButton";
            this.btnConfirm.Size = new System.Drawing.Size(90, 36);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Сохранить";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(80, 252);
            this.btnCancel.Name = "CancelButton";
            this.btnCancel.Size = new System.Drawing.Size(81, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.textBoxRepeatPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxRepeatPassword.Location = new System.Drawing.Point(3, 167);
            this.textBoxRepeatPassword.Name = "passAgainTextBox";
            this.textBoxRepeatPassword.Size = new System.Drawing.Size(236, 20);
            this.textBoxRepeatPassword.TabIndex = 8;
            this.textBoxRepeatPassword.UseSystemPasswordChar = true;
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRepeat.Location = new System.Drawing.Point(3, 140);
            this.lblRepeat.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.lblRepeat.Name = "label3";
            this.lblRepeat.Padding = new System.Windows.Forms.Padding(4);
            this.lblRepeat.Size = new System.Drawing.Size(138, 24);
            this.lblRepeat.TabIndex = 7;
            this.lblRepeat.Text = "Повторите пароль";
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.lblOld);
            this.flowLayoutPanel1.Controls.Add(this.textBoxOldPassword);
            this.flowLayoutPanel1.Controls.Add(this.lblNew);
            this.flowLayoutPanel1.Controls.Add(this.textBoxNewPassword);
            this.flowLayoutPanel1.Controls.Add(this.lblRepeat);
            this.flowLayoutPanel1.Controls.Add(this.textBoxRepeatPassword);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(247, 296);
            this.flowLayoutPanel1.TabIndex = 9;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Смена пароля";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

            this.flowLayoutPanel1.Location = new System.Drawing.Point(ClientSize.Width / 2 - 247 / 2, ClientSize.Height / 2 - 296 / 2);
        }

        #endregion

        private System.Windows.Forms.Label lblOld;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxRepeatPassword;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}