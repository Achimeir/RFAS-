﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RFAS
{
    public partial class FileForm : Form
    {
        public Models.File currentFile;
        public Models.AccessType accessType;
        public Models.User currUser;
        public FileForm(Models.File file,Models.AccessType accessType,Models.GrantDenyType grantDeny, Models.User currentUser)
        {
            InitializeComponent();
            this.currentFile = file;
            this.accessType = accessType;
            this.currUser = currentUser;
            this.Text = file.fileName.Split('.')[0];
            this.fileNameTextBox.Text = file.fileName;
            this.fileAccessTextBox.Text = accessType.ToString();
            this.grantCheckBoxView.Checked = (int)grantDeny >= 2;
            this.DenyCheckBoxView.Checked = (int) grantDeny % 2 == 1;
            this.isEncryptedCheckBox.Checked = currentFile.isEncrypted;
            initializeFile(accessType);
        }

        /* The function is responsible for initializing the file UI interface
         * in case of encrypted/decrypted/filetype change. */
        private void initializeFile(Models.AccessType accessType)
        {
            this.isEncryptedCheckBox.Checked = currentFile.isEncrypted;

            if (currentFile.fileType == Models.FileType.Text)
            {
                this.FileTextBox.Visible = true;
                this.FileTextBox.Enabled = true;
                if (accessType.ToString().Contains("R"))
                {
                    this.FileTextBox.Font = SystemFonts.DefaultFont;
                    this.FileTextBox.Text = File.ReadAllText(currentFile.filePath);
                }

                else
                {
                    this.FileTextBox.Font = SystemFonts.DefaultFont;
                    this.FileTextBox.Text = "אינך יכול לקרוא את הקובץ";
                    MessageBox.Show("אין לך הרשאות לקרוא את הקובץ", "תקלה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!accessType.ToString().Contains("W"))
                    this.FileTextBox.Enabled = false;
            }
            else
            {
                if (accessType.ToString().Contains("R"))
                {
                    Bitmap newImage = null;
                    using (var image = new Bitmap(currentFile.filePath))
                    {
                        newImage = new Bitmap(image);
                    }
                    this.FilePictureBox.Image = newImage;
                    this.FileTextBox.Visible = false;
                }
                else
                {
                    this.FileTextBox.Visible = true;
                    this.FileTextBox.Text = "אינך יכול לראות את התמונה";
                    this.FileTextBox.Enabled = false;
                    MessageBox.Show("אין לך הרשאות לקרוא את הקובץ", "תקלה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
     
        private void encryptButton_Click(object sender, EventArgs e)
        {
            // If the file is not yet encrypted.. encrypt it.
            if (!currentFile.isEncrypted)
            {
                currentFile.isEncrypted = true;
                string encryptData = null;
                // If it is picture.. use steganography.
                if (currentFile.fileType==Models.FileType.Picture)
                {
                    SteganographyDataForm form = new SteganographyDataForm();
                    var temp=form.ShowDialog();
                    encryptData = form.dataToEncrypt;
                }

                // encrypt the file!
                currentFile.Encrypt(currUser.userKeys.Item1, currUser.userKeys.Item2,encryptData);              
                initializeFile(accessType);
            }
            else
                MessageBox.Show("הקובץ כבר מוצפן","הצפנה");
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            // If the file is Encrypted, Decrypt it!.
            if (currentFile.isEncrypted)
            {
                currentFile.isEncrypted = false;
                currentFile.Decrypt(currUser.userKeys.Item1, currUser.userKeys.Item2);
                initializeFile(accessType);
            }
            else
                MessageBox.Show("הקובץ איננו מוצפן, קריאה נעימה","הצפנה");

        }

        private void FileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.accessType.ToString().Contains("RW") && this.currentFile.fileType==Models.FileType.Text)
                File.WriteAllText(currentFile.filePath, this.FileTextBox.Text);

            else if (this.accessType.ToString().Contains("W") && this.currentFile.fileType == Models.FileType.Text)
                File.AppendAllText(currentFile.filePath, this.FileTextBox.Text.Remove(this.FileTextBox.Text.IndexOf("אינך יכול לקרוא את הקובץ"), "אינך יכול לקרוא את הקובץ".Length));
        }

    }
}
