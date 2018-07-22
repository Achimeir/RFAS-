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
        public int score = 0;
        public NewUserForm()
        {
            InitializeComponent();
            // Initial the combobox with all the possible user types.
            ComboBxUserType.DataSource = Enum.GetValues(typeof(UserType));
        }

        private void txtBxCreateUser_Click(object sender, EventArgs e)
        {
            if(txtBxPsw.Text != String.Empty && txtBxUser.Text != String.Empty)
            {
                // If there isn't user with that user name(user name is unique).
                var users = Models.Environment.usersList.Where(u => u.userName == txtBxUser.Text);
                if (users.Any())
                {
                    MessageBox.Show("מצטערים, אבל שם המשתמש שבחרת כבר קיים...", "יצירת משתמשים", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // If the password strenght is good enough
                    if (score >= 4)
                    {
                        UserType UT = Utils.ParseEnum<UserType>(ComboBxUserType.SelectedItem.ToString());
                        User u = UserFactory.createUser(UT, txtBxUser.Text, txtBxPsw.Text);
                        // Add the user to the user list.
                        Models.Environment.usersList.Add(u);
                        MessageBox.Show(" נוצר בהצלחה " + txtBxUser.Text + " המשתמש ", "יצירת משתמש", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("בבקשה תבחר סיסמא חזקה יותר", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("יצירת המשתמש נכשלה","שגיאה",MessageBoxButtons.OK,MessageBoxIcon.Error);
            txtBxPsw.Text = string.Empty;
            txtBxUser.Text = string.Empty;
            ComboBxUserType.SelectedIndex = 0;

        }

        /* The function handles the password text changing
         * and shows the message according to the password strength */
        private void txtBxPsw_TextChanged(object sender, EventArgs e)
        {
            if (txtBxPsw.Text == String.Empty)
            {
                lblPswStrength.Text = String.Empty;
            }
            else
            {
                string passwordLengthText = "";
                score = PasswordCheckerWrapper.getPasswordScore(txtBxPsw.Text);
                if (score >= 0 && score < 2)
                {
                    passwordLengthText = "סיסמא חלשה!";
                    lblPswStrength.ForeColor = Color.Red;
                }
                else if (score >= 2 && score < 4)
                {
                    passwordLengthText = "סיסמא טובה!";
                    lblPswStrength.ForeColor = Color.Purple;
                }
                else
                {
                    passwordLengthText = "סיסמא מצויינת!";
                    lblPswStrength.ForeColor = Color.Green;
                }

                lblPswStrength.Text = passwordLengthText;

            }
        }
    }
}
