using System;

public static class Utils
{
    public static void InitializeListBox<T>(ListBox listBox, string displayString, string valueString, List<T> datasource)
    {
        listBox = null;
        listBox.DisplayMember = displayString;
        listBox.ValueMember = valueString;
        listBox.DataSource = datasource;
    }
}
