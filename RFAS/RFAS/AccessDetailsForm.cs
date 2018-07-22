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
        CList, //per user
        ACL, //per file
        AccessMatrix
    }
    public partial class AccessDetailsForm : Form
    {
        public AccessDetailsForm( Object obj, PurposeType purposeItem)
        {
            InitializeComponent();
            CreateMyListView(obj, purposeItem);
        }

        public void CreateMyListView(Object obj, PurposeType purposeItem)
        {
            listView.View = View.Details;
            listView.GridLines = true;
            listView.Sorting = SortOrder.Ascending;
          
            listView.Columns.Add("שם", 250, HorizontalAlignment.Center);
            listView.Columns.Add("הרשאה", 250, HorizontalAlignment.Center);

            if (purposeItem == PurposeType.CList)
            {
                this.label2.Text = ((Models.User)obj).userName + " הרשאות עבור המשתמש ";
                bool empty = true;
                foreach (var dictItem in ((Models.User)obj).userRole.filesDict)
                {
                    empty = false;
                    listView.Items.Add(new ListViewItem(dictItem.Key.fileName)).SubItems.Add((dictItem.Value.ToString()));
                }
                if (empty)
                    listView.Items.Add(new ListViewItem("ריק")).SubItems.Add(("ריק"));
            }

            else if (purposeItem == PurposeType.ACL)
            {
                this.label2.Text = ((Models.File)obj).fileName + " הרשאות עבור הקובץ";
                bool empty = true;
                foreach (Models.User user in Models.Environment.usersList)
                {
                    empty = false;
                    foreach (var dictItem in user.userRole.filesDict.Where(item => (item.Key.fileName == ((Models.File)obj).fileName)))
                    {
                        listView.Items.Add(new ListViewItem(user.userName)).SubItems.Add((dictItem.Value.ToString()));
                    }
                }
                if (empty)
                    listView.Items.Add(new ListViewItem("ריק")).SubItems.Add(("ריק"));
            }
            else if (purposeItem == PurposeType.AccessMatrix)
            {
                this.label2.Text = "מטריצת גישה מלאה";
                listView.Columns.Clear();
                listView.Items.Clear();
                listView.Columns.Add("משתמשים / קבצים",250);
                foreach (var user in Models.Environment.usersList)
                {
                    listView.Columns.Add(user.userName, 100);
                }

                bool empty = true;
                foreach (var file in Models.Environment.filesList)
                {
                    empty = false;
                    ListViewItem lwi= new ListViewItem (file.fileName);
                    foreach (var user in Models.Environment.usersList)
                    {
                        if (user.userRole.filesDict.ContainsKey(file))
                            lwi.SubItems.Add(user.userRole.filesDict[file].ToString());
                        else
                            lwi.SubItems.Add("ריק");

                        //listView.Items.Insert(listView.Items.IndexOfKey(dictItem.Key.fileName),(item.userRole.filesDict[dictItem.Key].ToString()));
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
