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
    public partial class SteganographyDataForm : Form
    {
        public string dataToEncrypt = "";
        public SteganographyDataForm()
        {
            InitializeComponent();
            this.textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "")
            {
                this.dataToEncrypt = this.textBox1.Text;
                this.Close();
            }
            else
                MessageBox.Show("בבקשה בחר טקסט להצפנה","תקלה",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
