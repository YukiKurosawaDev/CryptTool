namespace CryptTool
{
    partial class frmAES
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
            this.HexMode = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CryptedText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OriginalText = new System.Windows.Forms.TextBox();
            this.Decrypt = new System.Windows.Forms.Button();
            this.Crypt = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HexMode
            // 
            this.HexMode.AutoSize = true;
            this.HexMode.Location = new System.Drawing.Point(17, 12);
            this.HexMode.Name = "HexMode";
            this.HexMode.Size = new System.Drawing.Size(72, 16);
            this.HexMode.TabIndex = 4;
            this.HexMode.Text = "十六进制";
            this.HexMode.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CryptedText);
            this.groupBox2.Location = new System.Drawing.Point(6, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 164);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "加密文本/签名";
            // 
            // CryptedText
            // 
            this.CryptedText.Location = new System.Drawing.Point(11, 20);
            this.CryptedText.Multiline = true;
            this.CryptedText.Name = "CryptedText";
            this.CryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CryptedText.Size = new System.Drawing.Size(392, 138);
            this.CryptedText.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OriginalText);
            this.groupBox1.Location = new System.Drawing.Point(6, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 164);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "原始文本";
            // 
            // OriginalText
            // 
            this.OriginalText.Location = new System.Drawing.Point(11, 20);
            this.OriginalText.Multiline = true;
            this.OriginalText.Name = "OriginalText";
            this.OriginalText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OriginalText.Size = new System.Drawing.Size(392, 138);
            this.OriginalText.TabIndex = 4;
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(265, 415);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(72, 23);
            this.Decrypt.TabIndex = 7;
            this.Decrypt.Text = "解密";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Crypt
            // 
            this.Crypt.Location = new System.Drawing.Point(81, 415);
            this.Crypt.Name = "Crypt";
            this.Crypt.Size = new System.Drawing.Size(72, 23);
            this.Crypt.TabIndex = 8;
            this.Crypt.Text = "加密";
            this.Crypt.UseVisualStyleBackColor = true;
            this.Crypt.Click += new System.EventHandler(this.Crypt_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(120, 9);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(289, 19);
            this.txtKey.TabIndex = 11;
            this.txtKey.Text = "0102030405060708090A0B0C0D0E0F10";
            // 
            // frmAES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Crypt);
            this.Controls.Add(this.HexMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加密辅助工具 v1.0 - AES";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox HexMode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CryptedText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox OriginalText;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Button Crypt;
        private System.Windows.Forms.TextBox txtKey;
    }
}