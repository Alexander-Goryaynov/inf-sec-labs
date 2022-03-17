namespace laba2
{
    partial class FormMain
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.textBoxInputFile = new System.Windows.Forms.TextBox();
            this.textBoxEncryptFile = new System.Windows.Forms.TextBox();
            this.textBoxDecryptFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOpenInputFile = new System.Windows.Forms.Button();
            this.buttonOpenEncryptedFile = new System.Windows.Forms.Button();
            this.buttonOpenDecryptedFyle = new System.Windows.Forms.Button();
            this.radioButtonPassword = new System.Windows.Forms.RadioButton();
            this.radioButtonPasswordFile = new System.Windows.Forms.RadioButton();
            this.buttonOpenPasswordFile = new System.Windows.Forms.Button();
            this.textBoxPasswordFile = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInputFile
            // 
            this.textBoxInputFile.Enabled = false;
            this.textBoxInputFile.Location = new System.Drawing.Point(592, 29);
            this.textBoxInputFile.Name = "textBoxInputFile";
            this.textBoxInputFile.ReadOnly = true;
            this.textBoxInputFile.Size = new System.Drawing.Size(279, 20);
            this.textBoxInputFile.TabIndex = 1;
            // 
            // textBoxEncryptFile
            // 
            this.textBoxEncryptFile.Enabled = false;
            this.textBoxEncryptFile.Location = new System.Drawing.Point(592, 55);
            this.textBoxEncryptFile.Name = "textBoxEncryptFile";
            this.textBoxEncryptFile.ReadOnly = true;
            this.textBoxEncryptFile.Size = new System.Drawing.Size(279, 20);
            this.textBoxEncryptFile.TabIndex = 2;
            // 
            // textBoxDecryptFile
            // 
            this.textBoxDecryptFile.Enabled = false;
            this.textBoxDecryptFile.Location = new System.Drawing.Point(592, 81);
            this.textBoxDecryptFile.Name = "textBoxDecryptFile";
            this.textBoxDecryptFile.ReadOnly = true;
            this.textBoxDecryptFile.Size = new System.Drawing.Size(279, 20);
            this.textBoxDecryptFile.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(443, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Исходный файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(443, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Зашифрованный файл";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(443, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Расшифрованный файл";
            // 
            // buttonOpenInputFile
            // 
            this.buttonOpenInputFile.Location = new System.Drawing.Point(876, 26);
            this.buttonOpenInputFile.Name = "buttonOpenInputFile";
            this.buttonOpenInputFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenInputFile.TabIndex = 7;
            this.buttonOpenInputFile.Text = "Выбрать";
            this.buttonOpenInputFile.UseVisualStyleBackColor = true;
            this.buttonOpenInputFile.Click += new System.EventHandler(this.ButtonOpenInputFile_Click);
            // 
            // buttonOpenEncryptedFile
            // 
            this.buttonOpenEncryptedFile.Location = new System.Drawing.Point(876, 53);
            this.buttonOpenEncryptedFile.Name = "buttonOpenEncryptedFile";
            this.buttonOpenEncryptedFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenEncryptedFile.TabIndex = 8;
            this.buttonOpenEncryptedFile.Text = "Выбрать";
            this.buttonOpenEncryptedFile.UseVisualStyleBackColor = true;
            this.buttonOpenEncryptedFile.Click += new System.EventHandler(this.ButtonOpenEncryptedFile_Click);
            // 
            // buttonOpenDecryptedFyle
            // 
            this.buttonOpenDecryptedFyle.Location = new System.Drawing.Point(876, 79);
            this.buttonOpenDecryptedFyle.Name = "buttonOpenDecryptedFyle";
            this.buttonOpenDecryptedFyle.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenDecryptedFyle.TabIndex = 9;
            this.buttonOpenDecryptedFyle.Text = "Выбрать";
            this.buttonOpenDecryptedFyle.UseVisualStyleBackColor = true;
            this.buttonOpenDecryptedFyle.Click += new System.EventHandler(this.ButtonOpenDecryptedFyle_Click);
            // 
            // radioButtonPassword
            // 
            this.radioButtonPassword.AutoSize = true;
            this.radioButtonPassword.Checked = true;
            this.radioButtonPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPassword.Location = new System.Drawing.Point(447, 132);
            this.radioButtonPassword.Name = "radioButtonPassword";
            this.radioButtonPassword.Size = new System.Drawing.Size(69, 19);
            this.radioButtonPassword.TabIndex = 10;
            this.radioButtonPassword.TabStop = true;
            this.radioButtonPassword.Text = "Пароль";
            this.radioButtonPassword.UseVisualStyleBackColor = true;
            this.radioButtonPassword.CheckedChanged += new System.EventHandler(this.RadioButtonPassword_CheckedChanged);
            // 
            // radioButtonPasswordFile
            // 
            this.radioButtonPasswordFile.AutoSize = true;
            this.radioButtonPasswordFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonPasswordFile.Location = new System.Drawing.Point(447, 158);
            this.radioButtonPasswordFile.Name = "radioButtonPasswordFile";
            this.radioButtonPasswordFile.Size = new System.Drawing.Size(120, 19);
            this.radioButtonPasswordFile.TabIndex = 11;
            this.radioButtonPasswordFile.Text = "Файл с паролем";
            this.radioButtonPasswordFile.UseVisualStyleBackColor = true;
            this.radioButtonPasswordFile.CheckedChanged += new System.EventHandler(this.RadioButtonPasswordFile_CheckedChanged);
            // 
            // buttonOpenPasswordFile
            // 
            this.buttonOpenPasswordFile.Enabled = false;
            this.buttonOpenPasswordFile.Location = new System.Drawing.Point(876, 155);
            this.buttonOpenPasswordFile.Name = "buttonOpenPasswordFile";
            this.buttonOpenPasswordFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenPasswordFile.TabIndex = 15;
            this.buttonOpenPasswordFile.Text = "Выбрать";
            this.buttonOpenPasswordFile.UseVisualStyleBackColor = true;
            this.buttonOpenPasswordFile.Click += new System.EventHandler(this.ButtonOpenPasswordFile_Click);
            // 
            // textBoxPasswordFile
            // 
            this.textBoxPasswordFile.Enabled = false;
            this.textBoxPasswordFile.Location = new System.Drawing.Point(586, 156);
            this.textBoxPasswordFile.Name = "textBoxPasswordFile";
            this.textBoxPasswordFile.ReadOnly = true;
            this.textBoxPasswordFile.Size = new System.Drawing.Size(285, 20);
            this.textBoxPasswordFile.TabIndex = 13;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(586, 130);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(367, 20);
            this.textBoxPassword.TabIndex = 12;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEncrypt.Location = new System.Drawing.Point(540, 200);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(123, 34);
            this.buttonEncrypt.TabIndex = 16;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = false;
            this.buttonEncrypt.Click += new System.EventHandler(this.ButtonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecrypt.Location = new System.Drawing.Point(765, 200);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(123, 34);
            this.buttonDecrypt.TabIndex = 17;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = false;
            this.buttonDecrypt.Click += new System.EventHandler(this.ButtonDecrypt_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.OverwritePrompt = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 10F);
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(427, 246);
            this.label4.TabIndex = 18;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 264);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonOpenPasswordFile);
            this.Controls.Add(this.textBoxPasswordFile);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.radioButtonPasswordFile);
            this.Controls.Add(this.radioButtonPassword);
            this.Controls.Add(this.buttonOpenDecryptedFyle);
            this.Controls.Add(this.buttonOpenEncryptedFile);
            this.Controls.Add(this.buttonOpenInputFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDecryptFile);
            this.Controls.Add(this.textBoxEncryptFile);
            this.Controls.Add(this.textBoxInputFile);
            this.Name = "FormMain";
            this.Text = "Data Encryption Standard ECB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInputFile;
        private System.Windows.Forms.TextBox textBoxEncryptFile;
        private System.Windows.Forms.TextBox textBoxDecryptFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOpenInputFile;
        private System.Windows.Forms.Button buttonOpenEncryptedFile;
        private System.Windows.Forms.Button buttonOpenDecryptedFyle;
        private System.Windows.Forms.RadioButton radioButtonPassword;
        private System.Windows.Forms.RadioButton radioButtonPasswordFile;
        private System.Windows.Forms.Button buttonOpenPasswordFile;
        private System.Windows.Forms.TextBox textBoxPasswordFile;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label4;
    }
}

