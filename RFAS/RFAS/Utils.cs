using Models;
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

    public static void InitializeComboBox<T>(ComboBox comboBox, string displayString, string valueString, List<T> datasource)
    {
        comboBox.DataSource = null;
        comboBox.DisplayMember = displayString;
        comboBox.ValueMember = valueString;
        comboBox.DataSource = datasource;
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

    public static FileType getFileTypeAccordingToFile(string fileName)
    {
        // assuming txt/png is only available[?]
        if (fileName.Contains(".txt"))
            return FileType.Text;
        else
            return FileType.Picture;
    }
}
