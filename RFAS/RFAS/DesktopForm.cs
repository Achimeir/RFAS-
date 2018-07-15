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
        public Models.Environment environ;
        public DesktopForm(User currentUser)
        {
            InitializeComponent();
            environ = new Models.Environment(currentUser);


            Utils.InitializeListBox<Models.User>(lbUsers, "userName", "userName", Models.Environment.usersList);
            lbUsers.ClearSelected();
            


        }

        

        private void DesktopForm_Load(object sender, EventArgs e)
        {
            this.welcomLabel.Text = "ברוך הבא משתמש  " + environ.currentUser.userName;
        }

        private void welcomLabel_Click_2(object sender, EventArgs e)
        {
            //foreach (User item in Models.Environment.usersList)
            //    if (item.userName== environ.currentUser)
            //        MessageBox.Show("How are you feeling today " +item.userName + " ?", ";)", MessageBoxButtons.OK, MessageBoxIcon.Question);
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if there is a selected user
            bool delete_button_visibility = lbUsers.SelectedIndex != -1;
            btnDeleteUser.Visible = delete_button_visibility;

        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            User u = environ.currentUser;
            if (e.TabPageIndex > 0 && !(u is Admin))
            {
                // to do: make a list for each user type & check access.
                if (e.TabPage == userTab)
                {
                    e.Cancel = true;
                   
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            User u = (User)lbUsers.SelectedItem;
            if (u is Admin)
            {
                MessageBox.Show("מצטערים, אבל מחיקת אדמין היא לא אפשרית");
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("אתה בטוח שאתה רוצה למחוק את המשתמש " + u.userName + " ?" , "מחיקה",  MessageBoxButtons.YesNo))
            {
                Models.Environment.usersList.Remove(u);
                Utils.InitializeListBox<Models.User>(lbUsers, "userName", "userName", Models.Environment.usersList);
            }
        }

        private void btnCreateU_Click(object sender, EventArgs e)
        {
            NewUserForm NU = new NewUserForm();
            NU.ShowDialog();
            Utils.InitializeListBox<Models.User>(lbUsers, "userName", "userName", Models.Environment.usersList);
        }


    }
}
 