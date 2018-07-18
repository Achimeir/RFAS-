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
            //Utils.InitializeListBox<User>(lbUsers, "userName", "userName", Models.Environment.usersList);
            listsInitializer();
        }

        private void DesktopForm_Load(object sender, EventArgs e)
        {
            this.welcomLabel.Text = "ברוך הבא " + environ.currentUser.userName;
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
                listsInitializer();
                //Utils.InitializeListBox<User>(lbUsers, "userName", "userName", Models.Environment.usersList);
            }
        }

        private void btnCreateU_Click(object sender, EventArgs e)
        {
            NewUserForm NU = new NewUserForm();
            NU.ShowDialog();
            listsInitializer();
            //Utils.InitializeListBox<User>(lbUsers, "userName", "userName", Models.Environment.usersList);
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
                        listsInitializer();
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
                    listsInitializer();
                }
                else
                    MessageBox.Show("הקובץ קיים כבר במערכת ", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void listsInitializer()
        {

            IEnumerable<File> userFiles = Models.Environment.filesList.Where(fi =>environ.currentUser.userRole.filesDict.ContainsKey(fi));
            Utils.InitializeListBox<File>(lstBxFiles, "fileName", "fileName", userFiles.Where(fi => fi.fileType == FileType.Text).ToList());
            Utils.InitializeListBox<File>(lstBxPics, "fileName", "fileName", userFiles.Where(fi => fi.fileType == FileType.Picture).ToList());
            Utils.InitializeComboBox<File>(fileComboBox, "filename", "filename", Models.Environment.filesList);
            Utils.InitializeComboBox<User>(userComboBox, "userName", "userName", Models.Environment.usersList);
            Utils.InitializeComboBox<string>(accessComboBox, "accessName", "accessName", Enum.GetNames(typeof(AccessType)).ToList());
            Utils.InitializeListBox<User>(lbUsers, "userName", "userName", Models.Environment.usersList);

            canGranCheckBox.Checked = false;
            canDenyCheckBox.Checked = false;
            lbUsers.ClearSelected();
            lstBxFiles.ClearSelected();
            lstBxPics.ClearSelected();
            accessComboBox.SelectedIndex = -1;
            accessComboBox.Text="רשימת הרשאות";
            fileComboBox.SelectedIndex = -1;
            fileComboBox.Text="רשימת קבצים";
            userComboBox.SelectedIndex = -1;
            userComboBox.Text="רשימת משתמשים";
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
            if (lstBxFiles.SelectedIndex > -1)
            {
                File selectedFile = (File)lstBxFiles.SelectedItem;
                FileForm fileForm = new FileForm(selectedFile, environ.currentUser.userRole.filesDict[selectedFile]);
                fileForm.Show();
            }
        }

        private void lstBxPics_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstBxPics.SelectedIndex > -1)
            {
                File selectedFile = (File)lstBxPics.SelectedItem;
                FileForm fileForm = new FileForm(selectedFile, environ.currentUser.userRole.filesDict[selectedFile]);
                fileForm.Show();
            }
        }

        private void fileAccessButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: Show all file permission");
        }

        private void userAccessButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: show all user permission");
        }

        private void grantButton_Click(object sender, EventArgs e)
        {
            bool canGrant = (environ.currentUser is Admin)|| (environ.currentUser.userRole.filesDict.ContainsKey((File)fileComboBox.SelectedItem));
            if (canGrant)
            {
                if ((environ.currentUser is Admin) || (environ.currentUser.userRole.filesDict[(File)fileComboBox.SelectedItem].ToString().Contains(accessComboBox.SelectedValue.ToString())))
                {
                    ((User)userComboBox.SelectedItem).userRole.addFile((File)fileComboBox.SelectedItem, (AccessType)accessComboBox.SelectedIndex);
                    MessageBox.Show("premission " + (AccessType)accessComboBox.SelectedIndex + " granted for user " + ((User)userComboBox.SelectedItem).userName);

                }
            }
            else
                MessageBox.Show("you have no permission to grant this permission");

            listsInitializer();
        }

        private void denyButton_Click(object sender, EventArgs e)
        {
            bool canDeny = (environ.currentUser is Admin) || (environ.currentUser.userRole.filesDict.ContainsKey((File)fileComboBox.SelectedItem));
            if (canDeny)
            {
                //TODO: ניתן למחוק הרשאות רק לפי ביט can deny
                if ((environ.currentUser is Admin) || (environ.currentUser.userRole.filesDict[(File)fileComboBox.SelectedItem].ToString().Contains(accessComboBox.SelectedValue.ToString())))
                {
                    ((User)userComboBox.SelectedItem).userRole.discardFile((File)fileComboBox.SelectedItem);
                    MessageBox.Show("premission " + (AccessType)accessComboBox.SelectedIndex + " denyed for user " + ((User)userComboBox.SelectedItem).userName);
                }
            }
            else
                MessageBox.Show("you have no permission to grant this permission");

            listsInitializer();
        }

        private void passTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPassTextBox_TextChanged(object sender, EventArgs e)
        {
            int score = (int)((float)PasswordCheckerWrapper.getPasswordScore(newPassTextBox.Text)*2.5)%12;
            passTrackBar.Value = score;
            if (passTrackBar.Value<2)
                passTrackBar.BackColor = System.Drawing.Color.Red;
            else if (passTrackBar.Value < 4)
                passTrackBar.BackColor = System.Drawing.Color.Orange;
            else if (passTrackBar.Value < 6)
                passTrackBar.BackColor = System.Drawing.Color.Yellow;
            else if (passTrackBar.Value < 8)
                passTrackBar.BackColor = System.Drawing.Color.GreenYellow;
            else if (passTrackBar.Value < 10)
                passTrackBar.BackColor = System.Drawing.Color.Green;
            else if (passTrackBar.Value ==10)
                passTrackBar.BackColor = System.Drawing.Color.Blue;
        }

        private void passTrackBar_BackColorChanged(object sender, EventArgs e)
        {
            label8.BackColor = passTrackBar.BackColor;
            label9.BackColor = passTrackBar.BackColor;
        }

        private void changePassButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TODO: change pass and hash key");
        }
    }
}
 