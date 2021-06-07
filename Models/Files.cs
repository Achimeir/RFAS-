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

    // Text file representing a textual file in the system.
    public class TextFile : File
    {
        public TextFile(string fileName, string filePath, bool isEncrypted, List<string> validityBit, User creator, Classification classification = Classification.None) :
            base(fileName, filePath, isEncrypted, validityBit, creator, classification)
        {
            this.fileType = FileType.Text;
        }

        public override void Decrypt(byte[] key, byte[] iv)
        {
            try
            {
                var input = System.IO.File.ReadAllText(this.filePath);
                var inputInBytes = Convert.FromBase64String(input);
                string descryptedtext = AESEncryptionWrapper.getInstance().DecryptStringFromBytes(inputInBytes, key, iv);
                System.IO.File.WriteAllText(this.filePath, descryptedtext);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message+" הפענוח נכשל מהסיבה","תקלה",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Error);
            }
}

        public override void Encrypt(byte[] key, byte[] iv, string encryptData = null)
        {
            try
            {
                var input = System.IO.File.ReadAllText(this.filePath);
                byte[] encryptedBytes = AESEncryptionWrapper.getInstance().EncryptStringToBytes(input, key, iv);
                var cypherText = Convert.ToBase64String(encryptedBytes);
                System.IO.File.WriteAllText(this.filePath, cypherText);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message+" ההצפנה נכשלה מהסיבה", "תקלה", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }
    }

    // Picture file representing a picture in the file system.
    public class PictureFile : File
    {
        public PictureFile(string fileName, string filePath, bool isEncrypted, List<string> validityBit, User creator, Classification classification = Classification.None) : 
            base(fileName, filePath, isEncrypted, validityBit, creator, classification)
        {
            this.fileType = FileType.Picture;
        }

        public override void Decrypt(byte[] key, byte[] iv)
        {
            try
            {
                Image imgInput = Image.FromFile(this.filePath);
                System.Windows.Forms.MessageBox.Show(":הטקסט שהוצפן הוא"+ System.Environment.NewLine+SteganographyWrapper.ExtractTextFromImage((Bitmap)imgInput) , "פיענוח הצפנה");
                imgInput.Dispose();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + " הפענוח נכשל מהסיבה", "תקלה", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

        }

        public override void Encrypt(byte[] key, byte[] iv,string encryptData=null)
        {
            string temppic = Path.GetTempPath() + "temp" + Path.GetExtension(filePath);
            Image imgInput = Image.FromFile(this.filePath);
           
            imgInput =(Image)SteganographyWrapper.HideTextInImage(encryptData, (Bitmap)imgInput);
            imgInput.Save(temppic);
            imgInput.Dispose();

            System.IO.File.Delete(filePath);           
            System.IO.File.Copy(temppic, filePath);
        }
    }

    /* Base class representing a file.
     * A file is representing with the following:
     * Filename, filePath, isEncypted(indication if the file is encrypted),
     * validityBit, creator(the user who created the file) and the classification(TS, S, etc..)*/
    
    public abstract class File
    {
        public File(string fileName, string filePath, bool isEncrypted, List<string> validityBit, User creator, Classification classification=Classification.None)
        {
            this.fileName = fileName;
            this.filePath = filePath;
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
        

        /* Two abstract methods that each of the extending classes will implement
           Encrypt - for text - encrypting the text with key and IV. 
                     for image - hiding the encryptData in the image.
           Decrypt - exactly the opposite for Encryption.*/           
        public abstract void Encrypt(byte[] key, byte[] iv, string encryptData = null);
        public abstract void Decrypt(byte[] key, byte[] iv);


    }
}
