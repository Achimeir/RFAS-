namespace RFAS
{
    partial class NewUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUserForm));
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxUser = new System.Windows.Forms.TextBox();
            this.txtBxPsw = new System.Windows.Forms.TextBox();
            this.ComboBxUserType = new System.Windows.Forms.ComboBox();
            this.txtBxCreateUser = new System.Windows.Forms.Button();
            this.lblPswStrength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(240, 17);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserName.Size = new System.Drawing.Size(68, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "שם משתמש:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(264, 41);
            this.lblUser.Name = "lblUser";
            this.lblUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUser.Size = new System.Drawing.Size(44, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "סיסמא:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 67);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "סוג משתמש:";
            // 
            // txtBxUser
            // 
            this.txtBxUser.Location = new System.Drawing.Point(134, 14);
            this.txtBxUser.Name = "txtBxUser";
            this.txtBxUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBxUser.Size = new System.Drawing.Size(100, 20);
            this.txtBxUser.TabIndex = 3;
            // 
            // txtBxPsw
            // 
            this.txtBxPsw.Location = new System.Drawing.Point(134, 38);
            this.txtBxPsw.Name = "txtBxPsw";
            this.txtBxPsw.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBxPsw.Size = new System.Drawing.Size(100, 20);
            this.txtBxPsw.TabIndex = 4;
            this.txtBxPsw.TextChanged += new System.EventHandler(this.txtBxPsw_TextChanged);
            // 
            // ComboBxUserType
            // 
            this.ComboBxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBxUserType.FormattingEnabled = true;
            this.ComboBxUserType.Location = new System.Drawing.Point(134, 64);
            this.ComboBxUserType.Name = "ComboBxUserType";
            this.ComboBxUserType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ComboBxUserType.Size = new System.Drawing.Size(100, 21);
            this.ComboBxUserType.TabIndex = 5;
            // 
            // txtBxCreateUser
            // 
            this.txtBxCreateUser.Location = new System.Drawing.Point(144, 99);
            this.txtBxCreateUser.Name = "txtBxCreateUser";
            this.txtBxCreateUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBxCreateUser.Size = new System.Drawing.Size(83, 23);
            this.txtBxCreateUser.TabIndex = 6;
            this.txtBxCreateUser.Text = "צור משתמש!";
            this.txtBxCreateUser.UseVisualStyleBackColor = true;
            this.txtBxCreateUser.Click += new System.EventHandler(this.txtBxCreateUser_Click);
            // 
            // lblPswStrength
            // 
            this.lblPswStrength.AutoSize = true;
            this.lblPswStrength.Location = new System.Drawing.Point(40, 39);
            this.lblPswStrength.Name = "lblPswStrength";
            this.lblPswStrength.Size = new System.Drawing.Size(0, 13);
            this.lblPswStrength.TabIndex = 7;
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 134);
            this.Controls.Add(this.lblPswStrength);
            this.Controls.Add(this.txtBxCreateUser);
            this.Controls.Add(this.ComboBxUserType);
            this.Controls.Add(this.txtBxPsw);
            this.Controls.Add(this.txtBxUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "יצירת משתמש";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxUser;
        private System.Windows.Forms.TextBox txtBxPsw;
        private System.Windows.Forms.ComboBox ComboBxUserType;
        private System.Windows.Forms.Button txtBxCreateUser;
        private System.Windows.Forms.Label lblPswStrength;
    }
}