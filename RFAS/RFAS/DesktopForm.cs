using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace RFAS
{
    public partial class DesktopForm : Form
    {
        public Models.Environment environ = new Models.Environment(null, null, "Admin", null);
        public DesktopForm()
        {
            InitializeComponent();
        }

        private void DesktopForm_Load(object sender, EventArgs e)
        {
            this.welcomLabel.Text = "ברוך הבא משתמש  " + environ.currentUser;
        }

        private void welcomLabel_Click_2(object sender, EventArgs e)
        {
            foreach (User item in Models.Environment.usersList)
                if (item.userName== environ.currentUser)
                    MessageBox.Show("How are you feeling today " +item.userName + " ?", ";)", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void textFilelistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textFilelistBox.SelectedItem!=null)
            {
                string selectedFile = textFilelistBox.SelectedItem.ToString();
                MessageBox.Show("you select the file " + selectedFile, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textFilelistBox.ClearSelected();

            }
        }

        private void imageFileListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imageFileListBox.SelectedItem!=null)
            {
                string selectedImage = imageFileListBox.SelectedItem.ToString();
                MessageBox.Show("you select the image " + selectedImage, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                imageFileListBox.ClearSelected();
            }

        }
    }
}
 