﻿using System;
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
            lbUsers.ClearSelected();
            initializeFilesLists();
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
                // todo: make a list for each user type & check access.
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
            if (listBoxWithSelectedItem.SelectedItem != null)
            {
                File v = (File)listBoxWithSelectedItem.SelectedItem;
                if (DialogResult.Yes == MessageBox.Show("אתה בטוח שאתה רוצה למחוק את הקובץ הזה " + v.fileName + " ?", "מחיקה", MessageBoxButtons.YesNo))
                {
                    int userAccessPremission = (int)(environ.currentUser.userRole.filesDict[v]);
                    if (userAccessPremission == 3 || userAccessPremission >= 5)
                    {
                        Models.Environment.filesList.Remove(v);
                        MessageBox.Show(" נמחק " + v.fileName+" הקובץ ", "מחיקה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        initializeFilesLists();
                    }
                    else
                        MessageBox.Show(" ולכן אתה לא יכול למחוק " + (environ.currentUser.userRole.filesDict[v])+ " ההרשאות שלך לקובץ הן ", "שגיאה",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            // TODO: add also PNG/JPG to filter on file_dialog.
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                // TODO: fix parameters.
                // TODO: check permissions to do this thing.
                File f = new File(FileDialog.SafeFileName, FileDialog.FileName,
                    Utils.getFileTypeAccordingToFile(FileDialog.SafeFileName),
                    false, null, environ.currentUser);


                Random r = new Random();
                if (!Models.Environment.filesList.Exists(file => file.fileName == f.fileName))
                {
                    Models.Environment.filesList.Add(f);
                    AccessType accessType = (AccessType)r.Next(0, 8);

                    environ.currentUser.userRole.addFile(f, accessType);
                    initializeFilesLists();
                }
                else
                    MessageBox.Show("הקובץ קיים כבר במערכת ", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void initializeFilesLists()
        {
            IEnumerable<File> userFiles = Models.Environment.filesList.Where(fi => fi.creator == environ.currentUser);
            Utils.InitializeListBox<File>(lstBxFiles, "fileName", "fileName", userFiles.Where(fi => fi.fileType == FileType.Text).ToList());
            Utils.InitializeListBox<File>(lstBxPics, "fileName", "fileName", userFiles.Where(fi => fi.fileType == FileType.Picture).ToList());
            lstBxFiles.ClearSelected();
            lstBxPics.ClearSelected();
        }

        private void lstBxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.HandleOnlyOnceSelectedItemWithinListBox(lstBxFiles, lstBxPics);
        }

        private void lstBxPics_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.HandleOnlyOnceSelectedItemWithinListBox(lstBxPics, lstBxFiles);
        }

        private void lstBxFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            File selectedFile = (File)lstBxFiles.SelectedItem;
            FileForm fileForm = new FileForm(selectedFile, environ.currentUser.userRole.filesDict[selectedFile]);
            fileForm.Show();
        }

        private void lstBxPics_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            File selectedFile = (File)lstBxPics.SelectedItem;
            FileForm fileForm = new FileForm(selectedFile, environ.currentUser.userRole.filesDict[selectedFile]);
            fileForm.Show();
        }
    }
}
 