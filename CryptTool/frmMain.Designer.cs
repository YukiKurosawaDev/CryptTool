using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CryptTool
{
    partial class frmMain
    {
        private IContainer components = (IContainer)null;
        private ComboBox KeyLength;
        private Label label1;
        private ComboBox HashMethod;
        private Label label2;
        private Button GenerateKey;
        private Button ImportKey;
        private Button ExportKey;
        private CheckBox AlipayCompactible;
        private CheckBox SignMode;
        private TextBox OriginalText;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox CryptedText;
        private CheckBox HexMode;
        private Button Crypt;
        private Button Decrypt;
        private Button ViewKey;
        private Label label3;
        private Label KeyStatus;
        private OpenFileDialog ofd;
        private SaveFileDialog sfd;
        private Button About;

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.KeyLength = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HashMethod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerateKey = new System.Windows.Forms.Button();
            this.ImportKey = new System.Windows.Forms.Button();
            this.ExportKey = new System.Windows.Forms.Button();
            this.AlipayCompactible = new System.Windows.Forms.CheckBox();
            this.SignMode = new System.Windows.Forms.CheckBox();
            this.OriginalText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CryptedText = new System.Windows.Forms.TextBox();
            this.HexMode = new System.Windows.Forms.CheckBox();
            this.Crypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.ViewKey = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.KeyStatus = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.About = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyLength
            // 
            this.KeyLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KeyLength.FormattingEnabled = true;
            this.KeyLength.Items.AddRange(new object[] {
            "1024",
            "2048",
            "4096",
            "8192",
            "16384"});
            this.KeyLength.Location = new System.Drawing.Point(98, 36);
            this.KeyLength.Name = "KeyLength";
            this.KeyLength.Size = new System.Drawing.Size(121, 20);
            this.KeyLength.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "密钥长度";
            // 
            // HashMethod
            // 
            this.HashMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HashMethod.FormattingEnabled = true;
            this.HashMethod.Items.AddRange(new object[] {
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.HashMethod.Location = new System.Drawing.Point(314, 36);
            this.HashMethod.Name = "HashMethod";
            this.HashMethod.Size = new System.Drawing.Size(121, 20);
            this.HashMethod.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "散列方式";
            // 
            // GenerateKey
            // 
            this.GenerateKey.Location = new System.Drawing.Point(26, 76);
            this.GenerateKey.Name = "GenerateKey";
            this.GenerateKey.Size = new System.Drawing.Size(72, 23);
            this.GenerateKey.TabIndex = 2;
            this.GenerateKey.Text = "生成密钥";
            this.GenerateKey.UseVisualStyleBackColor = true;
            this.GenerateKey.Click += new System.EventHandler(this.GenerateKey_Click);
            // 
            // ImportKey
            // 
            this.ImportKey.Location = new System.Drawing.Point(107, 76);
            this.ImportKey.Name = "ImportKey";
            this.ImportKey.Size = new System.Drawing.Size(72, 23);
            this.ImportKey.TabIndex = 2;
            this.ImportKey.Text = "导入密钥";
            this.ImportKey.UseVisualStyleBackColor = true;
            this.ImportKey.Click += new System.EventHandler(this.ImportKey_Click);
            // 
            // ExportKey
            // 
            this.ExportKey.Location = new System.Drawing.Point(188, 76);
            this.ExportKey.Name = "ExportKey";
            this.ExportKey.Size = new System.Drawing.Size(72, 23);
            this.ExportKey.TabIndex = 2;
            this.ExportKey.Text = "导出密钥";
            this.ExportKey.UseVisualStyleBackColor = true;
            this.ExportKey.Click += new System.EventHandler(this.ExportKey_Click);
            // 
            // AlipayCompactible
            // 
            this.AlipayCompactible.AutoSize = true;
            this.AlipayCompactible.Location = new System.Drawing.Point(26, 118);
            this.AlipayCompactible.Name = "AlipayCompactible";
            this.AlipayCompactible.Size = new System.Drawing.Size(84, 16);
            this.AlipayCompactible.TabIndex = 3;
            this.AlipayCompactible.Text = "支付宝兼容";
            this.AlipayCompactible.UseVisualStyleBackColor = true;
            // 
            // SignMode
            // 
            this.SignMode.AutoSize = true;
            this.SignMode.Location = new System.Drawing.Point(113, 118);
            this.SignMode.Name = "SignMode";
            this.SignMode.Size = new System.Drawing.Size(72, 16);
            this.SignMode.TabIndex = 3;
            this.SignMode.Text = "验签模式";
            this.SignMode.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OriginalText);
            this.groupBox1.Location = new System.Drawing.Point(26, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 164);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "原始文本";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CryptedText);
            this.groupBox2.Location = new System.Drawing.Point(26, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 164);
            this.groupBox2.TabIndex = 6;
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
            // HexMode
            // 
            this.HexMode.AutoSize = true;
            this.HexMode.Location = new System.Drawing.Point(188, 118);
            this.HexMode.Name = "HexMode";
            this.HexMode.Size = new System.Drawing.Size(72, 16);
            this.HexMode.TabIndex = 3;
            this.HexMode.Text = "十六进制";
            this.HexMode.UseVisualStyleBackColor = true;
            // 
            // Crypt
            // 
            this.Crypt.Location = new System.Drawing.Point(71, 517);
            this.Crypt.Name = "Crypt";
            this.Crypt.Size = new System.Drawing.Size(72, 23);
            this.Crypt.TabIndex = 2;
            this.Crypt.Text = "加密/签名";
            this.Crypt.UseVisualStyleBackColor = true;
            this.Crypt.Click += new System.EventHandler(this.Crypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(255, 517);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(72, 23);
            this.Decrypt.TabIndex = 2;
            this.Decrypt.Text = "解密/验签";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // ViewKey
            // 
            this.ViewKey.Location = new System.Drawing.Point(266, 76);
            this.ViewKey.Name = "ViewKey";
            this.ViewKey.Size = new System.Drawing.Size(72, 23);
            this.ViewKey.TabIndex = 2;
            this.ViewKey.Text = "查看密钥";
            this.ViewKey.UseVisualStyleBackColor = true;
            this.ViewKey.Click += new System.EventHandler(this.ViewKey_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "密钥状态:";
            // 
            // KeyStatus
            // 
            this.KeyStatus.AutoSize = true;
            this.KeyStatus.Location = new System.Drawing.Point(331, 119);
            this.KeyStatus.Name = "KeyStatus";
            this.KeyStatus.Size = new System.Drawing.Size(41, 12);
            this.KeyStatus.TabIndex = 8;
            this.KeyStatus.Text = "未加载";
            // 
            // ofd
            // 
            this.ofd.Filter = "PKCS #1 格式密钥(*.pem)|*.pem";
            // 
            // sfd
            // 
            this.sfd.Filter = "PKCS #1 格式密钥(*.pem)|*.pem";
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(344, 76);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(72, 23);
            this.About.TabIndex = 2;
            this.About.Text = "关于程序";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 565);
            this.Controls.Add(this.KeyStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HexMode);
            this.Controls.Add(this.SignMode);
            this.Controls.Add(this.AlipayCompactible);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Crypt);
            this.Controls.Add(this.About);
            this.Controls.Add(this.ViewKey);
            this.Controls.Add(this.ExportKey);
            this.Controls.Add(this.ImportKey);
            this.Controls.Add(this.GenerateKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HashMethod);
            this.Controls.Add(this.KeyLength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加密辅助工具 v1.0 - RSA";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}