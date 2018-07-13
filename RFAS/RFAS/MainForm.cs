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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            bool successLogin = false;
            DesktopForm desktopForm = new DesktopForm();

            if (UserNameTextBox.Text != "user name" && passTextBox.Text!="Password")
            {
                foreach (User item in Models.Environment.usersList)
                {
                    if (item.userName == UserNameTextBox.Text && item.userPass == passTextBox.Text)
                    {
                        MessageBox.Show("Welcom user " + item.userName);
                        successLogin = true;
                        desktopForm.environ.currentUser = UserNameTextBox.Text;
                        break;
                    }
                }

                if (successLogin)
                    desktopForm.Show();

                else
                    MessageBox.Show("The user name or the password are incorrect","Login Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Please enter valid user name and password", "Login Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

    }
}
