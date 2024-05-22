using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CryptTool
{
    public class AESCTRCryptoHelper
    {
        public static byte[] Encrypt(byte[] key, byte[] iv, byte[] data)
        {
            byte[] keyBytes = key;
            IBufferedCipher cipher = CipherUtilities.GetCipher("AES/CTR/NoPadding");
            cipher.Init(true, new ParametersWithIV(ParameterUtilities.CreateKeyParameter("AES", keyBytes), iv));
            byte[] res = cipher.DoFinal(data);
            return res;
        }

        public static byte[] Decrypt(byte[] key, byte[] iv, byte[] data)
        {
            byte[] keyBytes = key;
            IBufferedCipher cipher = CipherUtilities.GetCipher("AES/CTR/NoPadding");
            cipher.Init(false, new ParametersWithIV(ParameterUtilities.CreateKeyParameter("AES", keyBytes), iv));
            byte[] res = cipher.DoFinal(data);
            return res;
        }
    }
}
