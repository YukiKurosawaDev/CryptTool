using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CryptTool
{
    public partial class frmMain : Form
    {
        private RSAParameters? pri;
        private RSAParameters? pub;
        

        public frmMain()
        {
            this.InitializeComponent();
        }

        private void Crypt_Click(object sender, EventArgs e)
        {
            if (this.SignMode.Checked)
            {
                byte[] numArray = RSACryptoHelper.Sign(this.pri.Value, this.HexMode.Checked ? RSACryptoHelper.ByteStringToHex(this.OriginalText.Text) : Encoding.UTF8.GetBytes(this.OriginalText.Text), this.HashMethod.SelectedItem.ToString());
                this.CryptedText.Text = this.HexMode.Checked ? RSACryptoHelper.HexToByteString(numArray) : Convert.ToBase64String(numArray);
            }
            else
            {
                byte[] numArray = RSACryptoHelper.Encrypt(this.pub.Value, this.HexMode.Checked ? RSACryptoHelper.ByteStringToHex(this.OriginalText.Text) : Encoding.UTF8.GetBytes(this.OriginalText.Text));
                this.CryptedText.Text = this.HexMode.Checked ? RSACryptoHelper.HexToByteString(numArray) : Convert.ToBase64String(numArray);
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            if (this.SignMode.Checked)
            {
                int num = (int)MessageBox.Show(RSACryptoHelper.Verify(this.pri.Value, this.HexMode.Checked ? RSACryptoHelper.ByteStringToHex(this.OriginalText.Text) : Encoding.UTF8.GetBytes(this.OriginalText.Text), this.HexMode.Checked ? RSACryptoHelper.ByteStringToHex(this.CryptedText.Text) : Convert.FromBase64String(this.CryptedText.Text), this.HashMethod.SelectedItem.ToString()) ? "验签通过" : "验签失败", "提示");
            }
            else
            {
                byte[] numArray = RSACryptoHelper.Decrypt(this.pri.Value, this.HexMode.Checked ? RSACryptoHelper.ByteStringToHex(this.CryptedText.Text) : Convert.FromBase64String(this.CryptedText.Text));
                this.OriginalText.Text = this.HexMode.Checked ? RSACryptoHelper.HexToByteString(numArray) : Encoding.UTF8.GetString(numArray);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.KeyLength.SelectedItem = (object)"2048";
            this.HashMethod.SelectedItem = (object)"SHA256";
        }

        private void ViewKey_Click(object sender, EventArgs e)
        {
            if (this.pri.HasValue)
            {
                int num1 = (int)frmKeyView.Show(this.pri.Value, this.AlipayCompactible.Checked);
            }
            else if (this.pub.HasValue)
            {
                int num2 = (int)frmKeyView.Show(this.pub.Value, this.AlipayCompactible.Checked);
            }
            else
            {
                int num3 = (int)MessageBox.Show("没有加载密钥", "提示");
            }
        }

        private void ExportKey_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("是否导出私钥数据?", "导出PKCS#1格式密钥", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1))
            {
                case DialogResult.Yes:
                    if (this.pri.HasValue)
                    {
                        if (this.sfd.ShowDialog() != DialogResult.OK)
                            break;
                        if (!this.AlipayCompactible.Checked)
                            File.WriteAllText(this.sfd.FileName, RSACryptoHelper.RSAKeyToPem(this.pri.Value, true), Encoding.UTF8);
                        else
                            File.WriteAllText(this.sfd.FileName, RSACryptoHelper.RSAKeyToPem(this.pri.Value, true).Replace("-----BEGIN RSA PRIVATE KEY-----", "").Replace("-----END RSA PRIVATE KEY-----", "").Replace(Environment.NewLine, ""), Encoding.UTF8);
                        break;
                    }
                    int num1 = (int)MessageBox.Show("没有加载密钥", "提示");
                    break;
                case DialogResult.No:
                    if (this.pub.HasValue)
                    {
                        if (this.sfd.ShowDialog() != DialogResult.OK)
                            break;
                        if (!this.AlipayCompactible.Checked)
                            File.WriteAllText(this.sfd.FileName, RSACryptoHelper.RSAKeyToPem(this.pub.Value, false), Encoding.UTF8);
                        else
                            File.WriteAllText(this.sfd.FileName, RSACryptoHelper.RSAKeyToPem(this.pub.Value, false).Replace("-----BEGIN PUBLIC KEY-----", "").Replace("-----END PUBLIC KEY-----", "").Replace(Environment.NewLine, ""), Encoding.UTF8);
                        break;
                    }
                    int num2 = (int)MessageBox.Show("没有加载密钥", "提示");
                    break;
            }
        }

        private void ImportKey_Click(object sender, EventArgs e)
        {
            if (this.ofd.ShowDialog() != DialogResult.OK)
                return;
            string pemKey = File.ReadAllText(this.ofd.FileName, Encoding.UTF8);
            RSAParameters rsaKey;
            if (!this.AlipayCompactible.Checked)
            {
                rsaKey = RSACryptoHelper.PemToRSAKey(pemKey);
            }
            else
            {
                try
                {
                    rsaKey = RSACryptoHelper.PemToRSAKey("-----BEGIN RSA PRIVATE KEY-----" + Environment.NewLine + pemKey + Environment.NewLine + "-----END RSA PRIVATE KEY-----");
                }
                catch
                {
                    rsaKey = RSACryptoHelper.PemToRSAKey("-----BEGIN PUBLIC KEY-----" + Environment.NewLine + pemKey + Environment.NewLine + "-----END PUBLIC KEY-----");
                }
            }
            RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider();
            cryptoServiceProvider.ImportParameters(rsaKey);
            if (cryptoServiceProvider.PublicOnly)
            {
                this.pub = new RSAParameters?(rsaKey);
                this.pri = new RSAParameters?();
                this.KeyStatus.Text = string.Format("已加载({0} bit)", (object)cryptoServiceProvider.KeySize);
            }
            else
            {
                this.pri = new RSAParameters?(rsaKey);
                this.pub = new RSAParameters?(cryptoServiceProvider.ExportParameters(false));
                this.KeyStatus.Text = string.Format("已加载({0} bit)", (object)cryptoServiceProvider.KeySize);
            }
        }

        private void About_Click(object sender, EventArgs e)
        {
            int num = (int)new frmAbout().ShowDialog();
        }

        private void GenerateKey_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider(int.Parse(this.KeyLength.SelectedItem.ToString()));
            this.pri = new RSAParameters?(cryptoServiceProvider.ExportParameters(true));
            this.pub = new RSAParameters?(cryptoServiceProvider.ExportParameters(false));
            this.KeyStatus.Text = string.Format("已加载({0} bit)", (object)cryptoServiceProvider.KeySize);
        }

    }
}
