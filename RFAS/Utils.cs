using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

/* Utils class used in the whole project */
public static class Utils
{
    /* The function initializes the given ListControl's DisplayMember,
     *  Value Member and DataSource property*/
    public static void InitializeListControl<T>(ListControl listControl, string displayString, string valueString, List<T> datasource)
    {
        listControl.DataSource = null;
        listControl.DisplayMember = displayString;
        listControl.ValueMember = valueString;
        listControl.DataSource = datasource;
    }

    // The function returns the Enumeration value(Template) of a given string.
    public static T ParseEnum<T>(string value)
    {
        return (T)Enum.Parse(typeof(T), value, true);
    }

    // The function receives two listboxes and makes sure only one is selected.
    public static void HandleOnlyOnceSelectedItemWithinListBox(ListBox f, ListBox o)
    {
        if(f.SelectedIndex != -1)
        {
            o.SelectedIndex = -1;
        }
    }

    /* The function receives a file name and returns the fileType according
     * to the extension of the file */
    public static FileType getFileTypeAccordingToFile(string fileName)
    {
        // assuming txt/png is only available[?]
        if (fileName.Contains(".txt"))
            return FileType.Text;
        else
            return FileType.Picture;
    }

}
