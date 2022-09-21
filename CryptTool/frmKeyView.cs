using System;
using System.ComponentModel;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CryptTool
{
    public partial class frmKeyView : Form
    {


        public frmKeyView()
        {
            this.InitializeComponent();
        }

        public static DialogResult Show(RSAParameters rsa, bool AlipayCompactible)
        {
            using (frmKeyView frmKeyView = new frmKeyView())
            {
                RSACryptoServiceProvider cryptoServiceProvider = new RSACryptoServiceProvider();
                cryptoServiceProvider.ImportParameters(rsa);
                RSAParameters rsaPara1 = cryptoServiceProvider.ExportParameters(false);
                frmKeyView.publicKey.Text = RSACryptoHelper.RSAKeyToPem(rsaPara1, false);
                if (!cryptoServiceProvider.PublicOnly)
                {
                    RSAParameters rsaPara2 = cryptoServiceProvider.ExportParameters(true);
                    frmKeyView.privateKey.Text = RSACryptoHelper.RSAKeyToPem(rsaPara2, true);
                }
                if (AlipayCompactible)
                {
                    frmKeyView.publicKey.Text = frmKeyView.publicKey.Text.Replace("-----BEGIN PUBLIC KEY-----", "").Replace("-----END PUBLIC KEY-----", "").Replace(Environment.NewLine, "");
                    frmKeyView.privateKey.Text = frmKeyView.privateKey.Text.Replace("-----BEGIN RSA PRIVATE KEY-----", "").Replace("-----END RSA PRIVATE KEY-----", "").Replace(Environment.NewLine, "");
                }
                return frmKeyView.ShowDialog();
            }
        }
    }
}
