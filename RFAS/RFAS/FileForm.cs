using System;
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
        public FileForm(Models.File file,Models.AccessType accessType)
        {
            InitializeComponent();
            this.currentFile = file;
            this.accessType = accessType;
            this.Text = file.fileName.Split('.')[0];
            this.fileNameTextBox.Text = file.fileName;
            this.fileAccessTextBox.Text = accessType.ToString();
            if (file.fileType == Models.FileType.Text)
                initializeFile(accessType);
            else
                initializePic(accessType);
        }

        private void initializeFile(Models.AccessType accessType)
        {
            this.FileTextBox.Visible = true;
            if (accessType.ToString().Contains("R"))
                this.FileTextBox.Text = File.ReadAllText(currentFile.filePath);
            else
            {
                this.FileTextBox.Text = "אינך יכול לקרוא את הקובץ";
                MessageBox.Show("אין לך הרשאות לקרוא את הקובץ");
            }
            if (!accessType.ToString().Contains("W"))
                this.FileTextBox.Enabled = false;
        }

        private void initializePic(Models.AccessType accessType)
        {

            if (accessType.ToString().Contains("R"))
            {
                this.FilePictureBox.Image = Image.FromFile(currentFile.filePath);
                this.FileTextBox.Visible = false;
            }
            else
            {
                this.FileTextBox.Visible = true;
                this.FileTextBox.Text = "אינך יכול לראות את התמונה";
                this.FileTextBox.Enabled = false;
                MessageBox.Show("אין לך הרשאות לקרוא את הקובץ");
            }
            
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: encrypt");
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: decrypt");
            File.Decrypt(currentFile.filePath);
            this.FileTextBox.Text = File.ReadAllText(currentFile.filePath);
        }

        private void FileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.accessType.ToString().Contains("RW") && this.currentFile.fileType==Models.FileType.Text)
                File.WriteAllText(currentFile.filePath, this.FileTextBox.Text);

        }

        private void FilePictureBox_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("Drag and drop");
            this.FilePictureBox.Image = (Image)e.Data;          
            
        }

        private void FilePictureBox_DragEnter(object sender, DragEventArgs e)
        {
            MessageBox.Show("Drag and enter");
            this.FilePictureBox.Image = (Image)e.Data;
        }
    }
}
