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
            // Create a new ListView control.
            // Set the view to show details.
            listView.View = View.Details;
            // Allow the user to edit item text.
           // listView.LabelEdit = true;
            // Allow the user to rearrange columns.
            //listView.AllowColumnReorder = true;
            // Display check boxes.
            //listView.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            //listView.FullRowSelect = true;
            // Display grid lines.
            listView.GridLines = true;
            // Sort the items in the list in ascending order.
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
                //listView.Items.AddRange(user.userRole.filesDict.ToList<ListViewItem>())
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

                       //     foreach (Models.User usr in Models.Environment.usersList.Where(item=>item.userRole.filesDict.ContainsKey(dictItem.Key)))
                       // {
                       //     usr.userRole.filesDict[dictItem.Key];
                       // }
            //}

            }

            // Create three items and three sets of subitems for each item.
            //ListViewItem item1 = new ListViewItem("קובץ 1", 0);
           // ListViewItem item1 = new ListViewItem("!");
            //item1.SubItems.AddRange("כתיבה",;
            // Place a check mark next to the item.

            //ListViewItem item2 = new ListViewItem("קובץ 2", 1);
            //item2.SubItems.Add("קריאה");

            //ListViewItem item3 = new ListViewItem("כתיבה");
            //ListViewItem item4 = new ListViewItem("קריאה");
            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.

            //listView.Columns.Add("שם",250, HorizontalAlignment.Left);
            // listView.Columns.Add("הרשאה", 250, HorizontalAlignment.Center);

            //Add the items to the ListView.

            //listView.Items.AddRange(new ListViewItem[] { item1, item2 });
            //listView.Items.AddRange(new ListViewItem[] { item3, item4 });
            // Add the ListView to the control collection.
            this.Controls.Add(listView);
        }


        private void accessMatrixButton_Click(object sender, EventArgs e)
        {
            CreateMyListView(null, PurposeType.AccessMatrix);
        }
    }


}
