using System;
using System.Collections.Generic;
using System.Text;
using System.IO;//System.IO.File
using System.Drawing;
using System.Security.Cryptography;

namespace Models
{
    public enum FileType
    {Text,Picture}

    public class File
    {
        public File(string fileName, string filePath, FileType fileType, bool isEncrypted, List<string> validityBit, User creator, Classification classification=Classification.None)
        {
            this.fileName = fileName;
            this.filePath = filePath;
            this.fileType = fileType;
            this.isEncrypted = isEncrypted;
            this.validityBit = validityBit;
            this.creator = creator;
            this.classification = classification;
        }

        public string fileName { get; set; }
        public string filePath { get; set; }
        public FileType fileType { get; set; }
        public bool isEncrypted { get; set; }
        public List<string> validityBit { get; set; }//list of 3 items first is permissions for the creator , second for admin and third for other users (rwd)
        public User creator { get; set; }
        public Classification classification { get; set; }

        public string[] Read ()
        {
            return null;
        }

        public void Write ()
        {

        }

        public void Encrypt (RSAParameters key)
        {
            if(this.fileType == FileType.Text)
            {
                RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
                csp.ImportParameters(key);
                var OriginalBytes = Convert.FromBase64String(System.IO.File.ReadAllText(this.filePath));
                int maxLength = RSAEncryptionWrapper.getInstance().GetMaxEncryptionChunkSize();
                int dataLength = OriginalBytes.Length;
                int iterations = dataLength / maxLength;

                System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
                for (int i = 0; i <= iterations; i++)
                {
                    int chunkSize = (dataLength - maxLength * i > maxLength) ?
                                    maxLength : dataLength - maxLength * i;
                    if (chunkSize == 0) {
                        break;
                    }

                    byte[] tempBytes = new byte[chunkSize];
                    System.Buffer.BlockCopy(OriginalBytes, maxLength * i,
                        tempBytes, 0, tempBytes.Length);
                    byte[] encriptedBytes = csp.Encrypt(tempBytes, false);

                    System.Array.Reverse(encriptedBytes);
                    arrayList.AddRange(encriptedBytes);
                }
                
                var cypherText = Convert.ToBase64String((byte[])arrayList.ToArray(Type.GetType("System.Byte")));
                System.IO.File.WriteAllText(this.filePath, cypherText);
            }
           }

        public void Decrypt(RSAParameters key)
        {
            if (this.fileType == FileType.Text)
            {
                RSACryptoServiceProvider csp = new RSACryptoServiceProvider();
                csp.ImportParameters(key);
                var OriginalBytes = Convert.FromBase64String(System.IO.File.ReadAllText(this.filePath));
                int EncriptedChunckSize = RSAEncryptionWrapper.getInstance().GetMaxEncryptionChunkSize();
                int dataLength = OriginalBytes.Length;
                int iterations = dataLength / EncriptedChunckSize;

                System.Collections.ArrayList arrayList =
                    new System.Collections.ArrayList();
                for (int i = 0; i < iterations; i++)
                {
                    byte[] tempBytes = new byte[EncriptedChunckSize];
                    System.Buffer.BlockCopy(OriginalBytes,EncriptedChunckSize * i,
                                            tempBytes, 0, tempBytes.Length);
                    System.Array.Reverse(tempBytes);

                    arrayList.AddRange(csp.Decrypt(tempBytes, false));
                }

                var cypherText = Convert.ToBase64String((byte[])arrayList.ToArray(Type.GetType("System.Byte")));
                System.IO.File.WriteAllText(this.filePath, cypherText);

            }
        }


    }
}
