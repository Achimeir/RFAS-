using System;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Models
{
    /* Class for wrapping the AES Encryption algorithm.
     * This class is a singelton */
    public class AESEncryptionWrapper
    {
        private static AESEncryptionWrapper instance = null;
        private RijndaelManaged AES;

        private AESEncryptionWrapper()
        {
            AES = new RijndaelManaged();
        }

        public static AESEncryptionWrapper getInstance()
        {
            if (instance == null)
                instance = new AESEncryptionWrapper();
            return instance;
        }

        // The function generates a random Key and Initialization Vector.
        public Tuple<byte[], byte[]> generateKeyAndVector()
        {
            AES.GenerateIV();
            AES.GenerateKey();
            return new Tuple<byte[], byte[]>(AES.Key, AES.IV);
        }

        /* The function received a string, key and initialiation vector and encrypts
           the input string with them */
        public byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            byte[] encrypted;

            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;
                
                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);
                
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            
            return encrypted;
        }

        /* The function receives byte array, key and initialization vector.
           The function returns the decrypted data from the byte array using the key and IV. */
        public string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            string plaintext = null;
            
            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;
                
                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);
                
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            try
                            {
                                plaintext = srDecrypt.ReadToEnd();
                            }
                            catch
                            {
                                MessageBox.Show("מצטערים, נראה שאין לך את המפתחות הנכונים לפיענוח הקובץ...");
                            }
                        }
                    }
                }
            }
            return plaintext;
        }


    }
}
