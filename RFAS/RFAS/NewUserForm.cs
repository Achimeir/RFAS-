using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RFAS
{
    public partial class NewUserForm : Form
    {
        public NewUserForm()
        {
            InitializeComponent();
            ComboBxUserType.DataSource = Enum.GetValues(typeof(UserType));
        }

        private void txtBxCreateUser_Click(object sender, EventArgs e)
        {
            if(txtBxPsw.Text != String.Empty && txtBxUser.Text != String.Empty)
            {
                var users = Models.Environment.usersList.Where(u => u.userName == txtBxUser.Text);
                if (users.Any())
                {
                    MessageBox.Show("מצטערים, אבל שם המשתמש שבחרת כבר קיים...");
                }
                else
                {
                    UserType UT = Utils.ParseEnum<UserType>(ComboBxUserType.SelectedItem.ToString());
                    User u = UserFactory.createUser(UT, txtBxUser.Text, txtBxPsw.Text);
                    Models.Environment.usersList.Add(u);
                }
            }
        }

        private void txtBxPsw_TextChanged(object sender, EventArgs e)
        {
            if (txtBxPsw.Text == String.Empty)
            {
                lblPswStrength.Text = String.Empty;
            }
            else
            {
                lblPswStrength.Text = PasswordCheckerWrapper.getPasswordScore(txtBxPsw.Text).ToString();
            }
        }
    }
}
