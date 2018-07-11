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

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void LoginPicture_Click(object sender, EventArgs e)
        {

        }

        private void userNameTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text != "user name" && passTextBox.Text!="Password")
            {
                MessageBox.Show("Welcome to the system " + UserNameTextBox.Text,"Welcome Message");
            }
            else
            {
                MessageBox.Show("Please enter valid user name and password", "Welcome Message");
            }
        }
    }
}
