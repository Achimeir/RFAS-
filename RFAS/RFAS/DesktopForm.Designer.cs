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
            this.environTab = new System.Windows.Forms.TabPage();
            this.passTab = new System.Windows.Forms.TabPage();
            this.permitionTab = new System.Windows.Forms.TabPage();
            this.filesTab = new System.Windows.Forms.TabPage();
            this.usersTab = new System.Windows.Forms.TabPage();
            this.desktopTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageFileListBox = new System.Windows.Forms.ListBox();
            this.textFilelistBox = new System.Windows.Forms.ListBox();
            this.welcomLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.desktopTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.environTab);
            this.tabControl.Controls.Add(this.passTab);
            this.tabControl.Controls.Add(this.permitionTab);
            this.tabControl.Controls.Add(this.filesTab);
            this.tabControl.Controls.Add(this.usersTab);
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
            // 
            // environTab
            // 
            this.environTab.BackColor = System.Drawing.Color.Transparent;
            this.environTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.environTab.Location = new System.Drawing.Point(4, 40);
            this.environTab.Margin = new System.Windows.Forms.Padding(0);
            this.environTab.Name = "environTab";
            this.environTab.Size = new System.Drawing.Size(789, 406);
            this.environTab.TabIndex = 4;
            this.environTab.Text = " סביבה  ";
            this.environTab.UseVisualStyleBackColor = true;
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
            // permitionTab
            // 
            this.permitionTab.BackColor = System.Drawing.Color.Transparent;
            this.permitionTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.permitionTab.Location = new System.Drawing.Point(4, 40);
            this.permitionTab.Margin = new System.Windows.Forms.Padding(0);
            this.permitionTab.Name = "permitionTab";
            this.permitionTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.permitionTab.Size = new System.Drawing.Size(789, 406);
            this.permitionTab.TabIndex = 2;
            this.permitionTab.Text = "  הרשאות  ";
            this.permitionTab.UseVisualStyleBackColor = true;
            // 
            // filesTab
            // 
            this.filesTab.BackColor = System.Drawing.Color.Transparent;
            this.filesTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.filesTab.Location = new System.Drawing.Point(4, 40);
            this.filesTab.Margin = new System.Windows.Forms.Padding(0);
            this.filesTab.Name = "filesTab";
            this.filesTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.filesTab.Size = new System.Drawing.Size(789, 406);
            this.filesTab.TabIndex = 1;
            this.filesTab.Text = "  קבצים  ";
            this.filesTab.UseVisualStyleBackColor = true;
            // 
            // usersTab
            // 
            this.usersTab.BackColor = System.Drawing.Color.Transparent;
            this.usersTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.usersTab.Location = new System.Drawing.Point(4, 40);
            this.usersTab.Margin = new System.Windows.Forms.Padding(0);
            this.usersTab.Name = "usersTab";
            this.usersTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usersTab.Size = new System.Drawing.Size(789, 406);
            this.usersTab.TabIndex = 0;
            this.usersTab.Text = "  משתמשים  ";
            this.usersTab.UseVisualStyleBackColor = true;
            // 
            // desktopTab
            // 
            this.desktopTab.BackColor = System.Drawing.Color.Transparent;
            this.desktopTab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.desktopTab.Controls.Add(this.loginButton);
            this.desktopTab.Controls.Add(this.label2);
            this.desktopTab.Controls.Add(this.label1);
            this.desktopTab.Controls.Add(this.imageFileListBox);
            this.desktopTab.Controls.Add(this.textFilelistBox);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(138, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "רשימת התמונות שלך";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(488, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "רשימת הקבצים שלך";
            // 
            // imageFileListBox
            // 
            this.imageFileListBox.FormattingEnabled = true;
            this.imageFileListBox.ItemHeight = 31;
            this.imageFileListBox.Items.AddRange(new object[] {
            "ttttt",
            "bbbb",
            "aaa",
            "qqq"});
            this.imageFileListBox.Location = new System.Drawing.Point(123, 111);
            this.imageFileListBox.Name = "imageFileListBox";
            this.imageFileListBox.Size = new System.Drawing.Size(192, 190);
            this.imageFileListBox.TabIndex = 3;
            this.imageFileListBox.SelectedIndexChanged += new System.EventHandler(this.imageFileListBox_SelectedIndexChanged);
            // 
            // textFilelistBox
            // 
            this.textFilelistBox.FormattingEnabled = true;
            this.textFilelistBox.ItemHeight = 31;
            this.textFilelistBox.Items.AddRange(new object[] {
            "ttttt",
            "bbbb",
            "aaa",
            "qqq"});
            this.textFilelistBox.Location = new System.Drawing.Point(470, 111);
            this.textFilelistBox.Name = "textFilelistBox";
            this.textFilelistBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textFilelistBox.Size = new System.Drawing.Size(192, 190);
            this.textFilelistBox.TabIndex = 2;
            this.textFilelistBox.SelectedIndexChanged += new System.EventHandler(this.textFilelistBox_SelectedIndexChanged);
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
            // DesktopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DesktopForm";
            this.Text = "DesktopForm";
            this.Load += new System.EventHandler(this.DesktopForm_Load);
            this.tabControl.ResumeLayout(false);
            this.desktopTab.ResumeLayout(false);
            this.desktopTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage usersTab;
        private System.Windows.Forms.TabPage filesTab;
        private System.Windows.Forms.TabPage permitionTab;
        private System.Windows.Forms.TabPage passTab;
        private System.Windows.Forms.TabPage environTab;
        private System.Windows.Forms.TabPage desktopTab;
        private System.Windows.Forms.Label welcomLabel;
        private System.Windows.Forms.ListBox textFilelistBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox imageFileListBox;
        private System.Windows.Forms.Button loginButton;
    }
}