using System.Windows.Forms;

namespace InfSec
{
    partial class FormPasswordPhrase
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
            this.lblPassPhrase = new System.Windows.Forms.Label();
            this.textBoxPassPhrase = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            this.lblPassPhrase.AutoSize = true;
            this.lblPassPhrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassPhrase.Location = new System.Drawing.Point(2, 0);
            this.lblPassPhrase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassPhrase.Name = "label1";
            this.lblPassPhrase.Size = new System.Drawing.Size(126, 16);
            this.lblPassPhrase.TabIndex = 0;
            this.lblPassPhrase.Text = "Парольная фраза";
            this.textBoxPassPhrase.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPassPhrase.Location = new System.Drawing.Point(2, 26);
            this.textBoxPassPhrase.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.textBoxPassPhrase.Name = "phraseTextBox";
            this.textBoxPassPhrase.Size = new System.Drawing.Size(216, 20);
            this.textBoxPassPhrase.TabIndex = 1;
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirm.Location = new System.Drawing.Point(72, 68);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.btnConfirm.Name = "SetButton";
            this.btnConfirm.Size = new System.Drawing.Size(76, 36);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "ОК";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(72, 108);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "CancelButton";
            this.btnCancel.Size = new System.Drawing.Size(76, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.lblPassPhrase);
            this.flowLayoutPanel1.Controls.Add(this.textBoxPassPhrase);
            this.flowLayoutPanel1.Controls.Add(this.btnConfirm);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(454, 183);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(222, 154);
            this.flowLayoutPanel1.TabIndex = 4;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SetPassPhraseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парольная фраза";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

            this.flowLayoutPanel1.Location = new System.Drawing.Point(ClientSize.Width / 2 - 222 / 2, ClientSize.Height / 2 - 154 / 2);
        }

        #endregion

        private System.Windows.Forms.Label lblPassPhrase;
        private System.Windows.Forms.TextBox textBoxPassPhrase;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}