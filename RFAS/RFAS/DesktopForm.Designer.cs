using Models;
namespace RFAS
{
    partial class DesktopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.envTab = new System.Windows.Forms.TabPage();
            this.passTab = new System.Windows.Forms.TabPage();
            this.permissionTab = new System.Windows.Forms.TabPage();
            this.filesTab = new System.Windows.Forms.TabPage();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnDeleteFiles = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstBxPics = new System.Windows.Forms.ListBox();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lstBxFiles = new System.Windows.Forms.ListBox();
            this.userTab = new System.Windows.Forms.TabPage();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.desktopTab = new System.Windows.Forms.TabPage();
            this.loginButton = new System.Windows.Forms.Button();
            this.welcomLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.filesTab.SuspendLayout();
            this.userTab.SuspendLayout();
            this.desktopTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.envTab);
            this.tabControl.Controls.Add(this.passTab);
            this.tabControl.Controls.Add(this.permissionTab);
            this.tabControl.Controls.Add(this.filesTab);
            this.tabControl.Controls.Add(this.userTab);
            this.tabControl.Controls.Add(this.desktopTab);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 5;
            this.tabControl.Size = new System.Drawing.Size(797, 450);
            this.tabControl.TabIndex = 1;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl_Selecting);
            // 
            // envTab
            // 
            this.envTab.BackColor = System.Drawing.Color.Transparent;
            this.envTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.envTab.Location = new System.Drawing.Point(4, 40);
            this.envTab.Margin = new System.Windows.Forms.Padding(0);
            this.envTab.Name = "envTab";
            this.envTab.Size = new System.Drawing.Size(789, 406);
            this.envTab.TabIndex = 4;
            this.envTab.Text = " סביבה  ";
            this.envTab.UseVisualStyleBackColor = true;
            // 
            // passTab
            // 
            this.passTab.BackColor = System.Drawing.Color.Transparent;
            this.passTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passTab.Location = new System.Drawing.Point(4, 40);
            this.passTab.Margin = new System.Windows.Forms.Padding(0);
            this.passTab.Name = "passTab";
            this.passTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passTab.Size = new System.Drawing.Size(789, 406);
            this.passTab.TabIndex = 3;
            this.passTab.Text = " סיסמאות והצפנה ";
            this.passTab.UseVisualStyleBackColor = true;
            // 
            // permissionTab
            // 
            this.permissionTab.BackColor = System.Drawing.Color.Transparent;
            this.permissionTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.permissionTab.Location = new System.Drawing.Point(4, 40);
            this.permissionTab.Margin = new System.Windows.Forms.Padding(0);
            this.permissionTab.Name = "permissionTab";
            this.permissionTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.permissionTab.Size = new System.Drawing.Size(789, 406);
            this.permissionTab.TabIndex = 2;
            this.permissionTab.Text = "  הרשאות  ";
            this.permissionTab.UseVisualStyleBackColor = true;
            // 
            // filesTab
            // 
            this.filesTab.BackColor = System.Drawing.Color.Transparent;
            this.filesTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.filesTab.Controls.Add(this.btnAddFile);
            this.filesTab.Controls.Add(this.btnDeleteFiles);
            this.filesTab.Controls.Add(this.label4);
            this.filesTab.Controls.Add(this.lstBxPics);
            this.filesTab.Controls.Add(this.lblFiles);
            this.filesTab.Controls.Add(this.lstBxFiles);
            this.filesTab.Location = new System.Drawing.Point(4, 40);
            this.filesTab.Margin = new System.Windows.Forms.Padding(0);
            this.filesTab.Name = "filesTab";
            this.filesTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.filesTab.Size = new System.Drawing.Size(789, 406);
            this.filesTab.TabIndex = 1;
            this.filesTab.Text = "  קבצים  ";
            this.filesTab.UseVisualStyleBackColor = true;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(252, 279);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(166, 48);
            this.btnAddFile.TabIndex = 12;
            this.btnAddFile.Text = "הוסף קובץ";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnDeleteFiles
            // 
            this.btnDeleteFiles.Location = new System.Drawing.Point(525, 279);
            this.btnDeleteFiles.Name = "btnDeleteFiles";
            this.btnDeleteFiles.Size = new System.Drawing.Size(166, 48);
            this.btnDeleteFiles.TabIndex = 11;
            this.btnDeleteFiles.Text = "מחק קובץ";
            this.btnDeleteFiles.UseVisualStyleBackColor = true;
            this.btnDeleteFiles.Click += new System.EventHandler(this.btnDeleteFiles_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(215, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "רשימת תמונות ששייכות לך";
            // 
            // lstBxPics
            // 
            this.lstBxPics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBxPics.DisplayMember = "userName";
            this.lstBxPics.FormattingEnabled = true;
            this.lstBxPics.ItemHeight = 31;
            this.lstBxPics.Location = new System.Drawing.Point(226, 71);
            this.lstBxPics.Name = "lstBxPics";
            this.lstBxPics.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstBxPics.Size = new System.Drawing.Size(192, 188);
            this.lstBxPics.TabIndex = 9;
            this.lstBxPics.ValueMember = "userName";
            this.lstBxPics.SelectedIndexChanged += new System.EventHandler(this.lstBxPics_SelectedIndexChanged);
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblFiles.Location = new System.Drawing.Point(525, 34);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(197, 24);
            this.lblFiles.TabIndex = 8;
            this.lblFiles.Text = "רשימת קבצים ששיכים לך";
            // 
            // lstBxFiles
            // 
            this.lstBxFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstBxFiles.DisplayMember = "userName";
            this.lstBxFiles.FormattingEnabled = true;
            this.lstBxFiles.ItemHeight = 31;
            this.lstBxFiles.Location = new System.Drawing.Point(525, 71);
            this.lstBxFiles.Name = "lstBxFiles";
            this.lstBxFiles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstBxFiles.Size = new System.Drawing.Size(192, 188);
            this.lstBxFiles.TabIndex = 7;
            this.lstBxFiles.ValueMember = "userName";
            this.lstBxFiles.SelectedIndexChanged += new System.EventHandler(this.lstBxFiles_SelectedIndexChanged);
            // 
            // userTab
            // 
            this.userTab.BackColor = System.Drawing.Color.Transparent;
            this.userTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userTab.Controls.Add(this.btnCreateUser);
            this.userTab.Controls.Add(this.btnDeleteUser);
            this.userTab.Controls.Add(this.label3);
            this.userTab.Controls.Add(this.lbUsers);
            this.userTab.Location = new System.Drawing.Point(4, 40);
            this.userTab.Margin = new System.Windows.Forms.Padding(0);
            this.userTab.Name = "userTab";
            this.userTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userTab.Size = new System.Drawing.Size(789, 406);
            this.userTab.TabIndex = 0;
            this.userTab.Text = "  משתמשים  ";
            this.userTab.UseVisualStyleBackColor = true;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(218, 161);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(176, 42);
            this.btnCreateUser.TabIndex = 8;
            this.btnCreateUser.Text = "הוסף משתמש";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateU_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(218, 71);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(176, 42);
            this.btnDeleteUser.TabIndex = 7;
            this.btnDeleteUser.Text = "מחק משתמש";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(542, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "רשימת משתמשים קיימים";
            // 
            // lbUsers
            // 
            this.lbUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbUsers.DisplayMember = "userName";
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 31;
            this.lbUsers.Location = new System.Drawing.Point(542, 71);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbUsers.Size = new System.Drawing.Size(192, 188);
            this.lbUsers.TabIndex = 5;
            this.lbUsers.ValueMember = "userName";
            this.lbUsers.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // desktopTab
            // 
            this.desktopTab.BackColor = System.Drawing.Color.Transparent;
            this.desktopTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.desktopTab.Controls.Add(this.loginButton);
            this.desktopTab.Controls.Add(this.welcomLabel);
            this.desktopTab.Location = new System.Drawing.Point(4, 40);
            this.desktopTab.Margin = new System.Windows.Forms.Padding(0);
            this.desktopTab.Name = "desktopTab";
            this.desktopTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.desktopTab.Size = new System.Drawing.Size(789, 406);
            this.desktopTab.TabIndex = 5;
            this.desktopTab.Text = "  בית  ";
            this.desktopTab.ToolTipText = "Home Page";
            this.desktopTab.UseVisualStyleBackColor = true;
            // 
            // loginButton
            // 
            this.loginButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.No;
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.loginButton.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(347, 360);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(94, 36);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Logout";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // welcomLabel
            // 
            this.welcomLabel.AutoSize = true;
            this.welcomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.welcomLabel.Location = new System.Drawing.Point(298, 7);
            this.welcomLabel.Name = "welcomLabel";
            this.welcomLabel.Size = new System.Drawing.Size(165, 24);
            this.welcomLabel.TabIndex = 0;
            this.welcomLabel.Text = "ברוך הבא משתמש X";
            this.welcomLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcomLabel.Click += new System.EventHandler(this.welcomLabel_Click_2);
            // 
            // DesktopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DesktopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DesktopForm";
            this.Load += new System.EventHandler(this.DesktopForm_Load);
            this.tabControl.ResumeLayout(false);
            this.filesTab.ResumeLayout(false);
            this.filesTab.PerformLayout();
            this.userTab.ResumeLayout(false);
            this.userTab.PerformLayout();
            this.desktopTab.ResumeLayout(false);
            this.desktopTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage userTab;
        private System.Windows.Forms.TabPage filesTab;
        private System.Windows.Forms.TabPage permissionTab;
        private System.Windows.Forms.TabPage passTab;
        private System.Windows.Forms.TabPage envTab;
        private System.Windows.Forms.TabPage desktopTab;
        private System.Windows.Forms.Label welcomLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstBxPics;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.ListBox lstBxFiles;
        private System.Windows.Forms.Button btnDeleteFiles;
        private System.Windows.Forms.Button btnAddFile;
    }
}