using System;
using System.Collections.Generic;
using System.Windows.Forms;

public static class Utils
{
    public static void InitializeListBox<T>(ListBox listBox, string displayString, string valueString, List<T> datasource)
    {
        listBox.DataSource = null;
        listBox.DisplayMember = displayString;
        listBox.ValueMember = valueString;
        listBox.DataSource = datasource;
    }

    public static T ParseEnum<T>(string value)
    {
        return (T)Enum.Parse(typeof(T), value, true);
    }

    public static void HandleOnlyOnceSelectedItemWithinListBox(ListBox f, ListBox o)
    {
        if(f.SelectedIndex != -1)
        {
            o.SelectedIndex = -1;
        }
    }
}
