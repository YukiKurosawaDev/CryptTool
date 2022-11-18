using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC;
using ECCurveA = Org.BouncyCastle.Math.EC.ECCurve;
using ECCurve = System.Security.Cryptography.ECCurve;
using Org.BouncyCastle.Asn1.Nist;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ECDsaCng ec=new ECDsaCng(ECCurve.NamedCurves.nistP521);
            var p=ec.ExportParameters(true);
            var q=new ECPrivateKeyParameters(new Org.BouncyCastle.Math.BigInteger(p.D),
                (ECDomainParameters)null );
            string empty = "";

            using (TextWriter writer = (TextWriter)new StringWriter())
            {
                PemWriter pemWriter = new PemWriter(writer);
                pemWriter.WriteObject((object)q);
                pemWriter.Writer.Flush();
                empty = writer.ToString();
            }

            Console.WriteLine(empty);
        }
    }
}
