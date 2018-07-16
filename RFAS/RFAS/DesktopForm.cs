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


            Utils.InitializeListBox<User>(lbUsers, "userName", "userName", Models.Environment.usersList);
            IEnumerable<File> userFiles = Models.Environment.filesList.Where(f => f.creator == currentUser);
            Utils.InitializeListBox<File>(lstBxFiles, "fileName", "fileName", userFiles.Where(f => f.fileType == FileType.Text).ToList());
            Utils.InitializeListBox<File>(lstBxPics, "fileName", "fileName", userFiles.Where(f => f.fileType == FileType.Picture).ToList());
            lbUsers.ClearSelected();
            lstBxFiles.ClearSelected();
            lstBxPics.ClearSelected();
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

        private void btnDeleteFiles_Click(object sender, EventArgs e)
        {
            // TODO: check permissions?
            ListBox listBoxWithSelectedItem = (lstBxFiles.SelectedIndex != -1) ? lstBxFiles : lstBxPics;
            File v = (File)listBoxWithSelectedItem.SelectedItem;
            if (DialogResult.Yes == MessageBox.Show("אתה בטוח שאתה רוצה למחוק את הקובץ הזה? " + v.fileName + " ?", "מחיקה", MessageBoxButtons.YesNo))
            {
                Models.Environment.filesList.Remove(v);
                IEnumerable<File> userFiles = Models.Environment.filesList.Where(f => f.creator == environ.currentUser);
                Utils.InitializeListBox<File>(lstBxFiles, "fileName", "fileName", userFiles.Where(f => f.fileType == FileType.Text).ToList());
                Utils.InitializeListBox<File>(lstBxPics, "fileName", "fileName", userFiles.Where(f => f.fileType == FileType.Picture).ToList());
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void lstBxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.HandleOnlyOnceSelectedItemWithinListBox(lstBxFiles, lstBxPics);
        }

        private void lstBxPics_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.HandleOnlyOnceSelectedItemWithinListBox(lstBxPics, lstBxFiles);
        }

        
    }
}
 