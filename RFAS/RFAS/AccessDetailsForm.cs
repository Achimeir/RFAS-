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
    public enum PurposeType
    {
        //access models
        CList,
        ACL,
        AccessMatrix
    }
    /*This form is Designed to display different types of secure access models:
 
     * CList - Capability list, each object (user) has a set of capabilities. a capability is a set of file and the access rights for this file
     * ACL - Access Control list , each file has a list that describes the access rights of every user to this file.
     * Access Matrix - a matrix that contains all the access rights between every file and user
     * 
     * */
    public partial class AccessDetailsForm : Form
    {
        public AccessDetailsForm( Object obj, PurposeType purposeItem)
        {
            InitializeComponent();
            CreateMyListView(obj, purposeItem); //this func do all the work, now just pass the wanted object (file or user) and access model
        }

        public void CreateMyListView(Object obj, PurposeType purposeItem)
        {
            //a basic initialization for the table (which based on listview)
            listView.View = View.Details;
            listView.GridLines = true;
            listView.Sorting = SortOrder.Ascending;          
            listView.Columns.Add("שם", 250, HorizontalAlignment.Center);
            listView.Columns.Add("הרשאה", 250, HorizontalAlignment.Center);

            //Display a CList
            if (purposeItem == PurposeType.CList)
            {
                this.label2.Text = ((Models.User)obj).userName + " הרשאות עבור המשתמש ";//header for the form
                bool empty = true;
                //scan every access right of the user stored in userRole.filesDict and exctarct them
                foreach (var dictItem in ((Models.User)obj).userRole.filesDict)
                {
                    //dictItem is a dictionary item, its key is the file name and its value is the user access for the file
                    empty = false;
                    //create a new entry in the CList that contains the file name and the acces type
                    listView.Items.Add(new ListViewItem(dictItem.Key.fileName)).SubItems.Add((dictItem.Value.ToString()));
                }
                if (empty)
                    listView.Items.Add(new ListViewItem("ריק")).SubItems.Add(("ריק"));//for empty clist
            }

            //Display ACL
            else if (purposeItem == PurposeType.ACL)
            {
                this.label2.Text = ((Models.File)obj).fileName + " הרשאות עבור הקובץ";//header for the form
                bool empty = true;
                //scan every user
                foreach (Models.User user in Models.Environment.usersList)
                {
                    empty = false;
                    //scan and extract only the users access rights for this file alone
                    foreach (var dictItem in user.userRole.filesDict.Where(item => (item.Key.fileName == ((Models.File)obj).fileName)))
                    {
                        //create a new entry in the ACL that contains the user name and the access type
                        listView.Items.Add(new ListViewItem(user.userName)).SubItems.Add((dictItem.Value.ToString()));
                    }
                }
                if (empty)
                    listView.Items.Add(new ListViewItem("ריק")).SubItems.Add(("ריק"));//for empty ACL
            }

            //display Access Matrix
            else if (purposeItem == PurposeType.AccessMatrix)
            {
                this.label2.Text = "מטריצת גישה מלאה";//header for the form
                listView.Columns.Clear();
                listView.Items.Clear();
                //add to the table a column for every user
                listView.Columns.Add("משתמשים / קבצים",250);
                foreach (var user in Models.Environment.usersList)
                {
                    listView.Columns.Add(user.userName, 100);
                }

                bool empty = true;
                //scan every file in the system
                foreach (var file in Models.Environment.filesList)
                {
                    empty = false;
                    //create a new line in the table, the first cell is the file name
                    ListViewItem lwi= new ListViewItem (file.fileName);
                    foreach (var user in Models.Environment.usersList)
                    {
                        //for every user in the system add its access type (if exists) for this file to the right cell
                        if (user.userRole.filesDict.ContainsKey(file))
                            lwi.SubItems.Add(user.userRole.filesDict[file].ToString()); 
                        else
                            lwi.SubItems.Add("ריק"); //if there is no access right
                    }
                    
                    listView.Items.Add(lwi);
                }

            }
            this.Controls.Add(listView);
        }


        private void accessMatrixButton_Click(object sender, EventArgs e)
        {
            CreateMyListView(null, PurposeType.AccessMatrix);
        }
    }


}
