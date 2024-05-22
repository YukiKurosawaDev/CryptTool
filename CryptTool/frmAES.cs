using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CryptTool
{
    public partial class frmAES : Form
    {
        public frmAES()
        {
            InitializeComponent();
        }

        private void Crypt_Click(object sender, EventArgs e)
        {
            byte[] data = null;
            if (HexMode.Checked)
            {
                data = RSACryptoHelper.ByteStringToHex(OriginalText.Text);
            }
            else
            {
                data = RSACryptoHelper.StringToHex(OriginalText.Text);
            };

            byte[] keyBytes= RSACryptoHelper.ByteStringToHex(txtKey.Text);
            byte[] iv = new byte[16] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5 };
            IBufferedCipher cipher = CipherUtilities.GetCipher("AES/CTR/NoPadding");
            cipher.Init(true, new ParametersWithIV(ParameterUtilities.CreateKeyParameter("AES", keyBytes), iv));
            byte[] res = cipher.DoFinal(data);

            if (HexMode.Checked)
            {
                CryptedText.Text = RSACryptoHelper.HexToByteString(res);
            }
            else
            {
                CryptedText.Text = RSACryptoHelper.HexToString(res);
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            byte[] data = null;
            if (HexMode.Checked)
            {
                data = RSACryptoHelper.ByteStringToHex(OriginalText.Text);
            }
            else
            {
                data = RSACryptoHelper.StringToHex(OriginalText.Text);
            }

            byte[] keyBytes = RSACryptoHelper.ByteStringToHex(txtKey.Text);
            byte[] iv = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 5 };
            IBufferedCipher cipher = CipherUtilities.GetCipher("AES/CTR/NoPadding");
            cipher.Init(false, new ParametersWithIV(ParameterUtilities.CreateKeyParameter("AES", keyBytes), iv));
            byte[] res = cipher.DoFinal(data);

            if (HexMode.Checked)
            {
                CryptedText.Text = RSACryptoHelper.HexToByteString(res);
            }
            else
            {
                CryptedText.Text = RSACryptoHelper.HexToString(res);
            }

            
            
        }
    }
}
