using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using Models;

namespace RFAS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AESEncryptionWrapper.getInstance();            
        }
        

      
        private void loginButton_Click(object sender, EventArgs e)
        {
            bool successLogin = false;
            DesktopForm desktopForm;

            
            if (UserNameTextBox.Text != "user name" && passTextBox.Text!="Password")
            {
                var users = Models.Environment.usersList.Where(u => u.userName == UserNameTextBox.Text && u.userPass == passTextBox.Text);

                successLogin = users.Any();


                if (successLogin)
                {
                    MessageBox.Show("Welcome user " + UserNameTextBox.Text, "Login successfully", MessageBoxButtons.OK, MessageBoxIcon.None);
                    // assuming there can only be one result.
                    desktopForm = new DesktopForm(users.First());
                    desktopForm.Text = UserNameTextBox.Text + " המחשב של";
                    UserNameTextBox.Text = "user name";
                    passTextBox.Text = "Password";
                    desktopForm.Show();
                }

                else
                    MessageBox.Show("The user name or the password are incorrect", "Login Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please enter valid user name and password", "Login Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
