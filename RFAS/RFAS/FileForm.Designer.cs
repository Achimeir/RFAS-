namespace RFAS
{
    partial class FileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileForm));
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.fileAccessTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FilePictureBox = new System.Windows.Forms.PictureBox();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.Button();
            this.grantCheckBoxView = new System.Windows.Forms.CheckBox();
            this.DenyCheckBoxView = new System.Windows.Forms.CheckBox();
            this.isEncryptedCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.FilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(681, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = ":שם הקובץ";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Enabled = false;
            this.fileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fileNameTextBox.Location = new System.Drawing.Point(507, 16);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(168, 30);
            this.fileNameTextBox.TabIndex = 1;
            // 
            // fileAccessTextBox
            // 
            this.fileAccessTextBox.Enabled = false;
            this.fileAccessTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fileAccessTextBox.Location = new System.Drawing.Point(57, 16);
            this.fileAccessTextBox.Name = "fileAccessTextBox";
            this.fileAccessTextBox.Size = new System.Drawing.Size(178, 30);
            this.fileAccessTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(241, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = ":הרשאות";
            // 
            // FilePictureBox
            // 
            this.FilePictureBox.Location = new System.Drawing.Point(158, 99);
            this.FilePictureBox.Name = "FilePictureBox";
            this.FilePictureBox.Size = new System.Drawing.Size(463, 289);
            this.FilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FilePictureBox.TabIndex = 4;
            this.FilePictureBox.TabStop = false;
            this.FilePictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.FilePictureBox_DragDrop);
            this.FilePictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.FilePictureBox_DragEnter);
            // 
            // FileTextBox
            // 
            this.FileTextBox.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileTextBox.Location = new System.Drawing.Point(147, 99);
            this.FileTextBox.Multiline = true;
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(463, 289);
            this.FileTextBox.TabIndex = 5;
            this.FileTextBox.Text = "temp info";
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(158, 395);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(130, 43);
            this.decryptButton.TabIndex = 6;
            this.decryptButton.Text = "פענח הצפנה";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(491, 395);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(130, 43);
            this.encryptButton.TabIndex = 7;
            this.encryptButton.Text = "הצפן";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // grantCheckBoxView
            // 
            this.grantCheckBoxView.AutoSize = true;
            this.grantCheckBoxView.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.grantCheckBoxView.Enabled = false;
            this.grantCheckBoxView.Location = new System.Drawing.Point(158, 52);
            this.grantCheckBoxView.Name = "grantCheckBoxView";
            this.grantCheckBoxView.Size = new System.Drawing.Size(74, 17);
            this.grantCheckBoxView.TabIndex = 8;
            this.grantCheckBoxView.Text = "יכול לתת";
            this.grantCheckBoxView.UseVisualStyleBackColor = true;
            this.grantCheckBoxView.CheckedChanged += new System.EventHandler(this.grantCheckBoxView_CheckedChanged);
            // 
            // DenyCheckBoxView
            // 
            this.DenyCheckBoxView.AutoSize = true;
            this.DenyCheckBoxView.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DenyCheckBoxView.Enabled = false;
            this.DenyCheckBoxView.Location = new System.Drawing.Point(57, 52);
            this.DenyCheckBoxView.Name = "DenyCheckBoxView";
            this.DenyCheckBoxView.Size = new System.Drawing.Size(84, 17);
            this.DenyCheckBoxView.TabIndex = 9;
            this.DenyCheckBoxView.Text = "יכול למנוע";
            this.DenyCheckBoxView.UseVisualStyleBackColor = true;
            // 
            // isEncryptedCheckBox
            // 
            this.isEncryptedCheckBox.AutoSize = true;
            this.isEncryptedCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isEncryptedCheckBox.Enabled = false;
            this.isEncryptedCheckBox.Location = new System.Drawing.Point(618, 52);
            this.isEncryptedCheckBox.Name = "isEncryptedCheckBox";
            this.isEncryptedCheckBox.Size = new System.Drawing.Size(57, 17);
            this.isEncryptedCheckBox.TabIndex = 10;
            this.isEncryptedCheckBox.Text = "מוצפן";
            this.isEncryptedCheckBox.UseVisualStyleBackColor = true;
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.isEncryptedCheckBox);
            this.Controls.Add(this.DenyCheckBoxView);
            this.Controls.Add(this.grantCheckBoxView);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.FileTextBox);
            this.Controls.Add(this.FilePictureBox);
            this.Controls.Add(this.fileAccessTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileForm";
            this.Text = "FileForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.FilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.TextBox fileAccessTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox FilePictureBox;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.CheckBox grantCheckBoxView;
        private System.Windows.Forms.CheckBox DenyCheckBoxView;
        private System.Windows.Forms.CheckBox isEncryptedCheckBox;
    }
}