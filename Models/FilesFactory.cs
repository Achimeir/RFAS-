﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /* This class is static and acts as a factory of files,
       with a given parameters and files types, it creates the
       wanted file*/
    public static class FilesFactory
    {
        public static File createFile(string fileName, string filePath, bool isEncrypted, List<string> validityBit, User creator, FileType fileType, Classification classification = Classification.None)
        {
            switch (fileType)
            {
                case FileType.Picture:
                    return new PictureFile(fileName, filePath, isEncrypted, validityBit, creator, classification);
                case FileType.Text:
                   return new TextFile(fileName, filePath, isEncrypted, validityBit, creator, classification);
                default:
                    return null;
            }
        }
    }
}
