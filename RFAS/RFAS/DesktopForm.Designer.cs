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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.passTab = new System.Windows.Forms.TabPage();
            this.changeHashButton = new System.Windows.Forms.Button();
            this.hashKeyTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.passTrackBar = new System.Windows.Forms.TrackBar();
            this.newPassTextBox = new System.Windows.Forms.TextBox();
            this.changePassButton = new System.Windows.Forms.Button();
            this.zeroPassUserComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.permissionTab = new System.Windows.Forms.TabPage();
            this.userAccessButton = new System.Windows.Forms.Button();
            this.fileAccessButton = new System.Windows.Forms.Button();
            this.denyButton = new System.Windows.Forms.Button();
            this.grantButton = new System.Windows.Forms.Button();
            this.canDenyCheckBox = new System.Windows.Forms.CheckBox();
            this.canGranCheckBox = new System.Windows.Forms.CheckBox();
            this.accessComboBox = new System.Windows.Forms.ComboBox();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.fileComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.envTab.SuspendLayout();
            this.passTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passTrackBar)).BeginInit();
            this.permissionTab.SuspendLayout();
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
            this.tabControl.Location = new System.Drawing.Point(0, 1);
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
            this.envTab.Controls.Add(this.label12);
            this.envTab.Controls.Add(this.label11);
            this.envTab.Controls.Add(this.label7);
            this.envTab.Location = new System.Drawing.Point(4, 40);
            this.envTab.Margin = new System.Windows.Forms.Padding(0);
            this.envTab.Name = "envTab";
            this.envTab.Size = new System.Drawing.Size(789, 406);
            this.envTab.TabIndex = 4;
            this.envTab.Text = " סביבה  ";
            this.envTab.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label12.Location = new System.Drawing.Point(-8, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(810, 97);
            this.label12.TabIndex = 2;
            this.label12.Text = "@@@@@@@@";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Webdings", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label11.Location = new System.Drawing.Point(-419, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 97);
            this.label11.TabIndex = 1;
            this.label11.Text = "@#";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(-10, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(800, 108);
            this.label7.TabIndex = 0;
            this.label7.Text = "סגור לרגל שיפוצים";
            // 
            // passTab
            // 
            this.passTab.BackColor = System.Drawing.Color.Transparent;
            this.passTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passTab.Controls.Add(this.changeHashButton);
            this.passTab.Controls.Add(this.hashKeyTextBox);
            this.passTab.Controls.Add(this.label10);
            this.passTab.Controls.Add(this.label9);
            this.passTab.Controls.Add(this.label8);
            this.passTab.Controls.Add(this.passTrackBar);
            this.passTab.Controls.Add(this.newPassTextBox);
            this.passTab.Controls.Add(this.changePassButton);
            this.passTab.Controls.Add(this.zeroPassUserComboBox);
            this.passTab.Controls.Add(this.label6);
            this.passTab.Location = new System.Drawing.Point(4, 40);
            this.passTab.Margin = new System.Windows.Forms.Padding(0);
            this.passTab.Name = "passTab";
            this.passTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passTab.Size = new System.Drawing.Size(789, 406);
            this.passTab.TabIndex = 3;
            this.passTab.Text = " סיסמאות והצפנה ";
            this.passTab.UseVisualStyleBackColor = true;
            this.passTab.Click += new System.EventHandler(this.passTab_Click);
            // 
            // changeHashButton
            // 
            this.changeHashButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.changeHashButton.Location = new System.Drawing.Point(50, 329);
            this.changeHashButton.Name = "changeHashButton";
            this.changeHashButton.Size = new System.Drawing.Size(121, 56);
            this.changeHashButton.TabIndex = 17;
            this.changeHashButton.Text = "החלף";
            this.changeHashButton.UseVisualStyleBackColor = true;
            this.changeHashButton.Click += new System.EventHandler(this.changeHashButton_Click);
            // 
            // hashKeyTextBox
            // 
            this.hashKeyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.hashKeyTextBox.Location = new System.Drawing.Point(319, 343);
            this.hashKeyTextBox.MaxLength = 16;
            this.hashKeyTextBox.Name = "hashKeyTextBox";
            this.hashKeyTextBox.Size = new System.Drawing.Size(266, 31);
            this.hashKeyTextBox.TabIndex = 16;
            this.hashKeyTextBox.Text = "XXXXXXXXXXXXXXXX";
            this.hashKeyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(587, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 31);
            this.label10.TabIndex = 15;
            this.label10.Text = "מפתח הצפנה:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(343, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "חזק";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(526, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "חלש";
            // 
            // passTrackBar
            // 
            this.passTrackBar.Location = new System.Drawing.Point(343, 200);
            this.passTrackBar.Name = "passTrackBar";
            this.passTrackBar.Size = new System.Drawing.Size(219, 45);
            this.passTrackBar.TabIndex = 12;
            this.passTrackBar.Scroll += new System.EventHandler(this.passTrackBar_Scroll);
            this.passTrackBar.BackColorChanged += new System.EventHandler(this.passTrackBar_BackColorChanged);
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.newPassTextBox.Location = new System.Drawing.Point(344, 163);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.Size = new System.Drawing.Size(218, 31);
            this.newPassTextBox.TabIndex = 11;
            this.newPassTextBox.Text = "בחר סיסמא חדשה";
            this.newPassTextBox.TextChanged += new System.EventHandler(this.newPassTextBox_TextChanged);
            // 
            // changePassButton
            // 
            this.changePassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.changePassButton.Location = new System.Drawing.Point(50, 120);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(121, 56);
            this.changePassButton.TabIndex = 10;
            this.changePassButton.Text = "איפוס";
            this.changePassButton.UseVisualStyleBackColor = true;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // zeroPassUserComboBox
            // 
            this.zeroPassUserComboBox.FormattingEnabled = true;
            this.zeroPassUserComboBox.Location = new System.Drawing.Point(344, 90);
            this.zeroPassUserComboBox.Name = "zeroPassUserComboBox";
            this.zeroPassUserComboBox.Size = new System.Drawing.Size(219, 39);
            this.zeroPassUserComboBox.TabIndex = 6;
            this.zeroPassUserComboBox.Text = "בחר משתמש";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "איפוס סיסמא:";
            // 
            // permissionTab
            // 
            this.permissionTab.BackColor = System.Drawing.Color.Transparent;
            this.permissionTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.permissionTab.Controls.Add(this.userAccessButton);
            this.permissionTab.Controls.Add(this.fileAccessButton);
            this.permissionTab.Controls.Add(this.denyButton);
            this.permissionTab.Controls.Add(this.grantButton);
            this.permissionTab.Controls.Add(this.canDenyCheckBox);
            this.permissionTab.Controls.Add(this.canGranCheckBox);
            this.permissionTab.Controls.Add(this.accessComboBox);
            this.permissionTab.Controls.Add(this.userComboBox);
            this.permissionTab.Controls.Add(this.fileComboBox);
            this.permissionTab.Controls.Add(this.label5);
            this.permissionTab.Controls.Add(this.label2);
            this.permissionTab.Controls.Add(this.label1);
            this.permissionTab.Location = new System.Drawing.Point(4, 40);
            this.permissionTab.Margin = new System.Windows.Forms.Padding(0);
            this.permissionTab.Name = "permissionTab";
            this.permissionTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.permissionTab.Size = new System.Drawing.Size(789, 406);
            this.permissionTab.TabIndex = 2;
            this.permissionTab.Text = "  הרשאות  ";
            this.permissionTab.UseVisualStyleBackColor = true;
            // 
            // userAccessButton
            // 
            this.userAccessButton.AutoEllipsis = true;
            this.userAccessButton.BackColor = System.Drawing.Color.Transparent;
            this.userAccessButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userAccessButton.BackgroundImage")));
            this.userAccessButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userAccessButton.FlatAppearance.BorderSize = 0;
            this.userAccessButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.userAccessButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.userAccessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userAccessButton.ForeColor = System.Drawing.Color.Transparent;
            this.userAccessButton.Location = new System.Drawing.Point(292, 132);
            this.userAccessButton.Name = "userAccessButton";
            this.userAccessButton.Size = new System.Drawing.Size(45, 39);
            this.userAccessButton.TabIndex = 13;
            this.userAccessButton.UseVisualStyleBackColor = true;
            this.userAccessButton.Click += new System.EventHandler(this.userAccessButton_Click);
            // 
            // fileAccessButton
            // 
            this.fileAccessButton.AutoEllipsis = true;
            this.fileAccessButton.BackColor = System.Drawing.Color.Transparent;
            this.fileAccessButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fileAccessButton.BackgroundImage")));
            this.fileAccessButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fileAccessButton.FlatAppearance.BorderSize = 0;
            this.fileAccessButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fileAccessButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fileAccessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileAccessButton.ForeColor = System.Drawing.Color.Transparent;
            this.fileAccessButton.Location = new System.Drawing.Point(292, 48);
            this.fileAccessButton.Name = "fileAccessButton";
            this.fileAccessButton.Size = new System.Drawing.Size(45, 39);
            this.fileAccessButton.TabIndex = 12;
            this.fileAccessButton.UseVisualStyleBackColor = true;
            this.fileAccessButton.Click += new System.EventHandler(this.fileAccessButton_Click);
            // 
            // denyButton
            // 
            this.denyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.denyButton.Location = new System.Drawing.Point(49, 246);
            this.denyButton.Name = "denyButton";
            this.denyButton.Size = new System.Drawing.Size(148, 82);
            this.denyButton.TabIndex = 11;
            this.denyButton.Text = "הסר הרשאה נבחרת";
            this.denyButton.UseVisualStyleBackColor = true;
            this.denyButton.Click += new System.EventHandler(this.denyButton_Click);
            // 
            // grantButton
            // 
            this.grantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.grantButton.Location = new System.Drawing.Point(49, 48);
            this.grantButton.Name = "grantButton";
            this.grantButton.Size = new System.Drawing.Size(148, 82);
            this.grantButton.TabIndex = 10;
            this.grantButton.Text = "הענק הרשאה נבחרת";
            this.grantButton.UseVisualStyleBackColor = true;
            this.grantButton.Click += new System.EventHandler(this.grantButton_Click);
            // 
            // canDenyCheckBox
            // 
            this.canDenyCheckBox.AutoSize = true;
            this.canDenyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.canDenyCheckBox.Location = new System.Drawing.Point(354, 300);
            this.canDenyCheckBox.Name = "canDenyCheckBox";
            this.canDenyCheckBox.Size = new System.Drawing.Size(166, 28);
            this.canDenyCheckBox.TabIndex = 9;
            this.canDenyCheckBox.Text = "יכול לבטל הרשאה";
            this.canDenyCheckBox.UseVisualStyleBackColor = true;
            // 
            // canGranCheckBox
            // 
            this.canGranCheckBox.AutoSize = true;
            this.canGranCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.canGranCheckBox.Location = new System.Drawing.Point(575, 300);
            this.canGranCheckBox.Name = "canGranCheckBox";
            this.canGranCheckBox.Size = new System.Drawing.Size(184, 28);
            this.canGranCheckBox.TabIndex = 8;
            this.canGranCheckBox.Text = "יכול להעניק הרשאה";
            this.canGranCheckBox.UseVisualStyleBackColor = true;
            // 
            // accessComboBox
            // 
            this.accessComboBox.FormattingEnabled = true;
            this.accessComboBox.Location = new System.Drawing.Point(354, 213);
            this.accessComboBox.Name = "accessComboBox";
            this.accessComboBox.Size = new System.Drawing.Size(219, 39);
            this.accessComboBox.TabIndex = 5;
            this.accessComboBox.Text = "רשימת הרשאות";
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(354, 132);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(219, 39);
            this.userComboBox.TabIndex = 4;
            this.userComboBox.Text = "רשימת משתמשים";
            // 
            // fileComboBox
            // 
            this.fileComboBox.FormattingEnabled = true;
            this.fileComboBox.Location = new System.Drawing.Point(354, 48);
            this.fileComboBox.Name = "fileComboBox";
            this.fileComboBox.Size = new System.Drawing.Size(219, 39);
            this.fileComboBox.TabIndex = 3;
            this.fileComboBox.Text = "רשימת קבצים";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "בחר הרשאה:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(607, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "בחר משתמש:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "בחר קובץ:";
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
            this.lstBxPics.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBxPics_MouseDoubleClick);
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
            this.lstBxFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstBxFiles_MouseDoubleClick);
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
            this.desktopTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("desktopTab.BackgroundImage")));
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
            this.loginButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.No;
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(347, 360);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(94, 36);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Logout";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // welcomLabel
            // 
            this.welcomLabel.AutoSize = true;
            this.welcomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.welcomLabel.ForeColor = System.Drawing.Color.Red;
            this.welcomLabel.Location = new System.Drawing.Point(266, 179);
            this.welcomLabel.Name = "welcomLabel";
            this.welcomLabel.Size = new System.Drawing.Size(203, 46);
            this.welcomLabel.TabIndex = 0;
            this.welcomLabel.Text = " ברוך הבא ";
            this.welcomLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcomLabel.Click += new System.EventHandler(this.welcomLabel_Click_2);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            this.FileDialog.Filter = "txt files (*.txt)|";
            this.FileDialog.InitialDirectory = "c:\\";
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
            this.envTab.ResumeLayout(false);
            this.envTab.PerformLayout();
            this.passTab.ResumeLayout(false);
            this.passTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passTrackBar)).EndInit();
            this.permissionTab.ResumeLayout(false);
            this.permissionTab.PerformLayout();
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
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.ComboBox accessComboBox;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.ComboBox fileComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox canDenyCheckBox;
        private System.Windows.Forms.CheckBox canGranCheckBox;
        private System.Windows.Forms.Button fileAccessButton;
        private System.Windows.Forms.Button denyButton;
        private System.Windows.Forms.Button grantButton;
        private System.Windows.Forms.Button userAccessButton;
        private System.Windows.Forms.TrackBar passTrackBar;
        private System.Windows.Forms.TextBox newPassTextBox;
        private System.Windows.Forms.Button changePassButton;
        private System.Windows.Forms.ComboBox zeroPassUserComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox hashKeyTextBox;
        private System.Windows.Forms.Button changeHashButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}