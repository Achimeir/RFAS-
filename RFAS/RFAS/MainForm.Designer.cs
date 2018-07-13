namespace RFAS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LoginPicture = new System.Windows.Forms.PictureBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPicture
            // 
            this.LoginPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginPicture.Image = global::RFAS.Properties.Resources.logo_pic;
            this.LoginPicture.Location = new System.Drawing.Point(326, 14);
            this.LoginPicture.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.LoginPicture.Name = "LoginPicture";
            this.LoginPicture.Size = new System.Drawing.Size(333, 309);
            this.LoginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginPicture.TabIndex = 0;
            this.LoginPicture.TabStop = false;
            // 
            // passTextBox
            // 
            this.passTextBox.AcceptsReturn = true;
            this.passTextBox.AcceptsTab = true;
            this.passTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passTextBox.Font = new System.Drawing.Font("Forte", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.passTextBox.Location = new System.Drawing.Point(379, 430);
            this.passTextBox.MaxLength = 15;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(223, 36);
            this.passTextBox.TabIndex = 3;
            this.passTextBox.Text = "Password";
            this.passTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passTextBox.UseSystemPasswordChar = true;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.AcceptsReturn = true;
            this.UserNameTextBox.AcceptsTab = true;
            this.UserNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserNameTextBox.Font = new System.Drawing.Font("FrankRuehl", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserNameTextBox.Location = new System.Drawing.Point(379, 385);
            this.UserNameTextBox.MaxLength = 15;
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(223, 36);
            this.UserNameTextBox.TabIndex = 2;
            this.UserNameTextBox.Text = "user name";
            this.UserNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Elephant", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.nameLabel.Location = new System.Drawing.Point(366, 293);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(257, 83);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "RFAS";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginButton
            // 
            this.loginButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(445, 477);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(83, 36);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(942, 538);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.LoginPicture);
            this.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainForm";
            this.Text = "RFAS";
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginPicture;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button loginButton;
    }
}

