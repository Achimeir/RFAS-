using System;
using System.Collections.Generic;
using System.Text;
using System.IO;//System.IO.File
using System.Drawing;
using System.Security.Cryptography;
using System.Drawing.Imaging;

namespace Models
{
    public enum FileType
    {Text,Picture}

    public class TextFile : File
    {
        public TextFile(string fileName, string filePath, bool isEncrypted, List<string> validityBit, User creator, Classification classification = Classification.None) :
            base(fileName, filePath, isEncrypted, validityBit, creator, classification)
        {
            this.fileType = FileType.Text;
        }

        public override void Decrypt(byte[] key, byte[] iv)
        {
            var input = System.IO.File.ReadAllText(this.filePath);
            byte[] encryptedBytes = AESEncryptionWrapper.getInstance().EncryptStringToBytes(input, key, iv);
            var cypherText = Convert.ToBase64String(encryptedBytes);
            System.IO.File.WriteAllText(this.filePath, cypherText);
        }

        public override void Encrypt(byte[] key, byte[] iv)
        {
            var input = System.IO.File.ReadAllText(this.filePath);
            var inputInBytes = Convert.FromBase64String(input);

            string descryptedtext = AESEncryptionWrapper.getInstance().DecryptStringFromBytes(inputInBytes, key, iv);
            System.IO.File.WriteAllText(this.filePath, descryptedtext);
        }
    }

    public class PictureFile : File
    {
        public PictureFile(string fileName, string filePath, bool isEncrypted, List<string> validityBit, User creator, Classification classification = Classification.None) : 
            base(fileName, filePath, isEncrypted, validityBit, creator, classification)
        {
            this.fileType = FileType.Picture;
        }

        public override void Decrypt(byte[] key, byte[] iv)
        {
            Image imgInput = Image.FromFile(this.filePath);
            using (var ms = new MemoryStream())
            {
                imgInput.Save(ms, imgInput.RawFormat);
                byte[] imageBytes = ms.ToArray();
                string imageStr = AESEncryptionWrapper.getInstance().DecryptStringFromBytes(imageBytes, key, iv);
                byte[] DecryptedimageBytes = Convert.FromBase64String(imageStr);
                System.IO.File.WriteAllBytes(this.filePath, imageBytes);
            }
        }

        public override void Encrypt(byte[] key, byte[] iv)
        {
            string temppic = Path.GetTempPath() + "\\temp" + Path.GetExtension(filePath);
            Image imgInput = Image.FromFile(this.filePath);
            using (var ms = new MemoryStream())
            {
                imgInput.Save(ms, imgInput.RawFormat);
                byte[] imageBytes =  ms.ToArray();
                string imageStr = Convert.ToBase64String(imageBytes);
                byte[] imageEncryptedBytes = AESEncryptionWrapper.getInstance().EncryptStringToBytes(imageStr, key, iv);                
                System.IO.File.WriteAllBytes(temppic, imageEncryptedBytes);
            }

            // stupid bug...
            System.IO.File.Delete(filePath);
            imgInput.Dispose();
            System.IO.File.Copy(temppic, filePath);
        }
    }
    public abstract class File
    {
        public File(string fileName, string filePath, bool isEncrypted, List<string> validityBit, User creator, Classification classification=Classification.None)
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
        

        public abstract void Encrypt(byte[] key, byte[] iv);
        public abstract void Decrypt(byte[] key, byte[] iv);


    }
}
