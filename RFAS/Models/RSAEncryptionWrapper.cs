using System;
using System.Security.Cryptography;

namespace Models
{
    public class RSAEncryptionWrapper
    {
        private static RSAEncryptionWrapper instance = null;
        private RSACryptoServiceProvider RSA;

        private RSAEncryptionWrapper()
        {
            RSA = new RSACryptoServiceProvider(2048);
        }

        public static RSAEncryptionWrapper getInstance()
        {
            if (instance == null)
                instance = new RSAEncryptionWrapper();
            return instance;
        }

        public RSAParameters CreateAndGetKey(bool isPrivate)
        {
            return RSA.ExportParameters(isPrivate);
        }

        public string CreateAndGetKeyAsString(bool isPrivate)
        {
            var key = CreateAndGetKey(isPrivate);
            var sw = new System.IO.StringWriter();
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, key);
            return sw.ToString();
        }

        public RSAParameters ConvertFromStringKeyToRSAParameters(string key)
        {
            var sr = new System.IO.StringReader(key);
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            return (RSAParameters)xs.Deserialize(sr);
        }

        public Tuple<RSAParameters, RSAParameters> CreateKeys()
        {
            Tuple<RSAParameters, RSAParameters> keys =
                new Tuple<RSAParameters, RSAParameters>(CreateAndGetKey(true),
                                                        CreateAndGetKey(false));
            return keys;
        }

        public int GetMaxEncryptionChunkSize()
        {
            return RSA.KeySize / 8 - 11;
        }



    }
}
