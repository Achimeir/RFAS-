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
        public Models.Environment environ;          // The current environment object.
        public DesktopForm(User currentUser)
        {
            InitializeComponent();
            environ = new Models.Environment(currentUser);
            listsInitializer();
        }


        private void DesktopForm_Load(object sender, EventArgs e)
        {
            this.welcomLabel.Text = "ברוך הבא " + environ.currentUser.userName;
        }

        private void welcomLabel_Click_2(object sender, EventArgs e)
        {}
        

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if there is a selected user, show button.
            bool delete_button_visibility = lbUsers.SelectedIndex != -1;
            btnDeleteUser.Visible = delete_button_visibility;

        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // Prevent user which is not admin to go into the userTab 
            User u = environ.currentUser;
            if (e.TabPageIndex > 0 && !(u is Admin))
            {
                if (e.TabPage == userTab)
                {
                    e.Cancel = true;
                   
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // Only let delete when user is a admin.
            User u = (User)lbUsers.SelectedItem;
            if (u is Admin)
            {
                MessageBox.Show("מצטערים, אבל מחיקת אדמין היא לא אפשרית","תקלה",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (DialogResult.Yes == MessageBox.Show("? " + u.userName + " אתה בטוח שאתה רוצה למחוק את המשתמש", "מחיקה",  MessageBoxButtons.YesNo))
            {
                Models.Environment.usersList.Remove(u);
                listsInitializer();
            }
        }

        private void btnCreateU_Click(object sender, EventArgs e)
        {
            // Create the newUserForm form.
            NewUserForm NU = new NewUserForm();
            NU.ShowDialog();
            listsInitializer();
        }

        private void btnDeleteFiles_Click(object sender, EventArgs e)
        {
            // Add option to delete the file
            ListBox listBoxWithSelectedItem = (lstBxFiles.SelectedIndex != -1) ? lstBxFiles : lstBxPics;
            if (listBoxWithSelectedItem.SelectedItem != null)
            {
                File v = (File)listBoxWithSelectedItem.SelectedItem;
                if (DialogResult.Yes == MessageBox.Show("? " + v.fileName + " אתה בטוח שאתה רוצה למחוק את הקובץ הזה", "מחיקה", MessageBoxButtons.YesNo))
                {
                    // check if the user is permitted to do this action.
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
            // If the user wanted to add the file.
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {

                File f = FilesFactory.createFile(FileDialog.SafeFileName, FileDialog.FileName,
                    false, null, environ.currentUser, Utils.getFileTypeAccordingToFile(FileDialog.SafeFileName));

                
                Random r = new Random();
                if (!Models.Environment.filesList.Exists(file => file.fileName == f.fileName))
                {
                    Models.Environment.filesList.Add(f);
                    // Randomly create accessType to the file..
                    AccessType accessType = (AccessType)r.Next(0, 8);
                    // Add the file to the current user .
                    environ.currentUser.userRole.addFile(f, accessType);
                    listsInitializer();
                }
                else
                    MessageBox.Show("הקובץ קיים כבר במערכת ", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /* The function serves as initializer for all the types of listcontrols in the form*/
        private void listsInitializer()
        {

            IEnumerable<File> userFiles = Models.Environment.filesList.Where(fi =>environ.currentUser.userRole.filesDict.ContainsKey(fi));
            Utils.InitializeListControl<File>(lstBxFiles, "fileName", "fileName", userFiles.Where(fi => fi.fileType == FileType.Text).ToList());
            Utils.InitializeListControl<File>(lstBxPics, "fileName", "fileName", userFiles.Where(fi => fi.fileType == FileType.Picture).ToList());
            Utils.InitializeListControl<File>(fileComboBox, "filename", "filename", Models.Environment.filesList);
            Utils.InitializeListControl<User>(userComboBox, "userName", "userName", Models.Environment.usersList);
            Utils.InitializeListControl<string>(accessComboBox, "accessName", "accessName", Enum.GetNames(typeof(AccessType)).ToList());
            Utils.InitializeListControl<User>(lbUsers, "userName", "userName", Models.Environment.usersList);

            if (environ.currentUser is Admin)
                Utils.InitializeListControl<User>(zeroPassUserComboBox, "userName", "userName", Models.Environment.usersList);
            else
                Utils.InitializeListControl<User>(zeroPassUserComboBox, "userName", "userName", new List<User>() { environ.currentUser });

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
            // If there is a file selected on the double click, open a form for it..
            if (lstBxFiles.SelectedIndex > -1)
            {
                File selectedFile = (File)lstBxFiles.SelectedItem;
                FileForm fileForm = new FileForm(selectedFile, environ.currentUser.userRole.filesDict[selectedFile], environ.currentUser.userRole.grantDenyDict[selectedFile],
                                            environ.currentUser);
                fileForm.Show();
            }
        }

        private void lstBxPics_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // If there is a file selected on the double click, open a form for it..
            if (lstBxPics.SelectedIndex > -1)
            {
                File selectedFile = (File)lstBxPics.SelectedItem;
                FileForm fileForm = new FileForm(selectedFile, environ.currentUser.userRole.filesDict[selectedFile], environ.currentUser.userRole.grantDenyDict[selectedFile], environ.currentUser);
                fileForm.Show();
            }
        }

        private void fileAccessButton_Click(object sender, EventArgs e)
        {
            // Handle the file access button, show the access detail form for it.
            if (fileComboBox.SelectedIndex < 0)
                return;
            AccessDetailsForm accessDetailsForm = new AccessDetailsForm((File)fileComboBox.SelectedItem, PurposeType.ACL);
            accessDetailsForm.Show();
        }

        private void userAccessButton_Click(object sender, EventArgs e)
        {
            // Handle the file access button, show the access detail form for it.
            if (userComboBox.SelectedIndex < 0)
                return;
            AccessDetailsForm accessDetailsForm = new AccessDetailsForm((User)userComboBox.SelectedItem, PurposeType.CList);
            accessDetailsForm.Show();
        }

        private void grantButton_Click(object sender, EventArgs e)
        {
            // handle the grant button for grandting privileges to other users.
            foreach (ComboBox item in ((Button)sender).Parent.Controls.OfType<ComboBox>())
            {
                if (item.SelectedIndex < 0)
                    return;
            }

            bool legalUser = (environ.currentUser is Admin)|| (environ.currentUser.userRole.grantDenyDict.ContainsKey((File)fileComboBox.SelectedItem));

            if (legalUser)
            {
                bool canGrant = (environ.currentUser.userRole.grantDenyDict[(File)fileComboBox.SelectedItem]>=GrantDenyType.Grant);
                bool havePrem = (environ.currentUser.userRole.filesDict[(File)fileComboBox.SelectedItem].ToString().Contains(accessComboBox.SelectedValue.ToString()));
                if ((environ.currentUser is Admin) || (canGrant &&havePrem))
                {                   
                    int grantDenyValue = (canDenyCheckBox.Checked ? 1 : 0) + (canGranCheckBox.Checked ? 2 : 0);
                    ((User)userComboBox.SelectedItem).userRole.addFile((File)fileComboBox.SelectedItem, (AccessType)accessComboBox.SelectedIndex,(GrantDenyType)grantDenyValue);
                    MessageBox.Show(((User)userComboBox.SelectedItem).userName+ " למשתמש " + (AccessType)accessComboBox.SelectedIndex + " נתת הרשאת ","הרשאה",MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show(((File)fileComboBox.SelectedItem).fileName + " לקובץ " + (AccessType)accessComboBox.SelectedIndex+" אתה לא רשאי לתת הרשאה מסוג","תקלה",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
                MessageBox.Show(((File)fileComboBox.SelectedItem).fileName + " לא קיימות הרשאות עבור הקובץ","תקלה",MessageBoxButtons.OK,MessageBoxIcon.Error);

            listsInitializer();
        }

        private void denyButton_Click(object sender, EventArgs e)
        {
            // handle the deny button for grandting privileges to other users.
            foreach (ComboBox item in ((Button)sender).Parent.Controls.OfType<ComboBox>())
            {
                if (item.SelectedIndex < 0)
                    return;
            }

            bool legalUser = (environ.currentUser is Admin) || (environ.currentUser.userRole.grantDenyDict.ContainsKey((File)fileComboBox.SelectedItem));

            if (legalUser)
            {

                bool canDeny= new List<GrantDenyType>() { GrantDenyType.Deny, GrantDenyType.GrantDeny }.Exists(item => item == environ.currentUser.userRole.grantDenyDict[(File)fileComboBox.SelectedItem]);
                bool havePrem = (environ.currentUser.userRole.filesDict[(File)fileComboBox.SelectedItem].ToString().Contains(accessComboBox.SelectedValue.ToString()));

                if ((environ.currentUser is Admin) || (canDeny&&havePrem))
                {
                    if (((User)userComboBox.SelectedItem).userRole.filesDict.ContainsKey((File)fileComboBox.SelectedItem))
                    {
                        ((User)userComboBox.SelectedItem).userRole.discardAccess((File)fileComboBox.SelectedItem, (AccessType)accessComboBox.SelectedIndex);
                        MessageBox.Show(((User)userComboBox.SelectedItem).userName + " למשתמש " + (AccessType)accessComboBox.SelectedIndex + " מחקת הרשאת","מחיקת הרשאות");
                    }

                    else
                        MessageBox.Show(((File)fileComboBox.SelectedItem).fileName + " לקובץ "+(AccessType)accessComboBox.SelectedIndex +" אין הרשאת " +((User)userComboBox.SelectedItem).userName + " למשתמש","מחיקת הרשאות");
                }
                else
                    MessageBox.Show(((File)fileComboBox.SelectedItem).fileName + " לקובץ " + (AccessType)accessComboBox.SelectedIndex + " אתה לא רשאי למחוק הרשאה מסוג","מחיקת הרשאות",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
                MessageBox.Show(((File)fileComboBox.SelectedItem).fileName+" לא קיימות הרשאות עבור הקובץ","תקלה",MessageBoxButtons.OK,MessageBoxIcon.Error);

            listsInitializer();
        }

        /* The function handles the textbox text changed event and change the color
         * according to the password strength */
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



        // The function the password change button event.
        private void changePassButton_Click(object sender, EventArgs e)
        {
            if (passTrackBar.Value <= 8)
                MessageBox.Show("עליך לבחור סיסמא חזקה יותר","בחירת סיסמא",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                ((User)zeroPassUserComboBox.SelectedItem).userPass = newPassTextBox.Text;
                MessageBox.Show(newPassTextBox.Text + " הסיסמא החדשה היא ", "בחירת סיסמא", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newPassTextBox.Text = "בחר סיסמא חדשה";
                zeroPassUserComboBox.Refresh();
                zeroPassUserComboBox.Text = "בחר משתמש";
                passTrackBar.Value = 0;
                passTrackBar.BackColor = SystemColors.Control;
            }
        }

        private void changeHashButton_Click(object sender, EventArgs e)
        {
            if (environ.currentUser is RegularUser || environ.currentUser is Admin)
            {
                ((RegularUser)environ.currentUser).userHashKey = hashKeyTextBox.Text;
                MessageBox.Show(hashKeyTextBox.Text + " מפתח ההצפנה החדש הוא ", "מפתחות הצפנה", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hashKeyTextBox.Text = "XXXXXXXXXXXXXXXXX";
            }
            else
                MessageBox.Show("אורחים לא יכולים לשנות מפתחות הצפנה", "מפתחות הצפנה", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
 