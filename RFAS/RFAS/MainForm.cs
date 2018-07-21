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

namespace RFAS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RSAEncryptionWrapper.getInstance();
            //lets take a new CSP with a new 2048 bit rsa key pair
            var csp = new RSACryptoServiceProvider(2048);

            //how to get the private key
            var privKey = csp.ExportParameters(true);

            //and the public key ...
            var pubKey = csp.ExportParameters(false);

            //converting the public key into a string representation
            string pubKeyString;
            {
                //we need some buffer
                var sw = new System.IO.StringWriter();
                //we need a serializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //serialize the key into the stream
                xs.Serialize(sw, pubKey);
                //get the string from the stream
                pubKeyString = sw.ToString();
            }

            //converting it back
            {
                //get a stream from the string
                var sr = new System.IO.StringReader(pubKeyString);
                //we need a deserializer
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                //get the object back from the stream
                pubKey = (RSAParameters)xs.Deserialize(sr);
            }

            //conversion for the private key is no black magic either ... omitted

            //we have a public key ... let's get a new csp and load that key
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(pubKey);

            //we need some data to encrypt
            var plainTextData = "foobar";

            //for encryption, always handle bytes...
            var bytesPlainTextData = System.Text.Encoding.Unicode.GetBytes(plainTextData);

            //apply pkcs#1.5 padding and encrypt our data 
            var bytesCypherText = csp.Encrypt(bytesPlainTextData, false);

            //we might want a string representation of our cypher text... base64 will do
            var cypherText = Convert.ToBase64String(bytesCypherText);


            /*
             * some transmission / storage / retrieval
             * 
             * and we want to decrypt our cypherText
             */

            //first, get our bytes back from the base64 string ...
            bytesCypherText = Convert.FromBase64String(cypherText);

            //we want to decrypt, therefore we need a csp and load our private key
            csp = new RSACryptoServiceProvider();
            csp.ImportParameters(privKey);

            //decrypt and strip pkcs#1.5 padding
            bytesPlainTextData = csp.Decrypt(bytesCypherText, false);

            //get our original plainText back...
            plainTextData = System.Text.Encoding.Unicode.GetString(bytesPlainTextData);
        
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
