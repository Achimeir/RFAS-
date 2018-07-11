using System;
using System.Collections.Generic;
using System.Text;
using System.IO;//System.IO.File
using System.Drawing;

namespace Models
{
    public enum FileType
    {Text,Picture}

    public enum Classification
    {
        TS,
        Secret,
        Confidential,
        Restricted,
        Official,
        Unclassified,
        None
    }

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

        }

        public void Write ()
        {

        }

        public File Encrypt (string userHashKey)
        {

        }

        public File Decrypt (string userHashKey)
        {

        }


    }
}
