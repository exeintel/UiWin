namespace UIwin;

public static class ListBox
{
    public static void AddItem(int controlHandle, string item)
    {
        HandleManager.GetControl<System.Windows.Forms.ListBox>(controlHandle).Items.Add(item);
    }

    public static void Clear(int controlHandle)
    {
        HandleManager.GetControl<System.Windows.Forms.ListBox>(controlHandle).Items.Clear();
    }

    public static int GetSelectedIndex(int controlHandle)
    {
        return HandleManager.GetControl<System.Windows.Forms.ListBox>(controlHandle).SelectedIndex;
    }

    public static string? GetSelectedItem(int controlHandle)
    {
        var lb = HandleManager.GetControl<System.Windows.Forms.ListBox>(controlHandle);
        return lb.SelectedItem?.ToString();
    }

    public static void SetSelectedIndex(int controlHandle, int index)
    {
        HandleManager.GetControl<System.Windows.Forms.ListBox>(controlHandle).SelectedIndex = index;
    }

    public static int GetItemCount(int controlHandle)
    {
        return HandleManager.GetControl<System.Windows.Forms.ListBox>(controlHandle).Items.Count;
    }

    public static void RemoveItem(int controlHandle, int index)
    {
        HandleManager.GetControl<System.Windows.Forms.ListBox>(controlHandle).Items.RemoveAt(index);
    }
}

public static class ComboBox
{
    public static void AddItem(int controlHandle, string item)
    {
        HandleManager.GetControl<System.Windows.Forms.ComboBox>(controlHandle).Items.Add(item);
    }

    public static void Clear(int controlHandle)
    {
        HandleManager.GetControl<System.Windows.Forms.ComboBox>(controlHandle).Items.Clear();
    }

    public static int GetSelectedIndex(int controlHandle)
    {
        return HandleManager.GetControl<System.Windows.Forms.ComboBox>(controlHandle).SelectedIndex;
    }

    public static string? GetSelectedItem(int controlHandle)
    {
        var cb = HandleManager.GetControl<System.Windows.Forms.ComboBox>(controlHandle);
        return cb.SelectedItem?.ToString();
    }

    public static void SetSelectedIndex(int controlHandle, int index)
    {
        HandleManager.GetControl<System.Windows.Forms.ComboBox>(controlHandle).SelectedIndex = index;
    }

    public static int GetItemCount(int controlHandle)
    {
        return HandleManager.GetControl<System.Windows.Forms.ComboBox>(controlHandle).Items.Count;
    }

    public static void SetEditable(int controlHandle, bool editable)
    {
        var cb = HandleManager.GetControl<System.Windows.Forms.ComboBox>(controlHandle);
        cb.DropDownStyle = editable ? ComboBoxStyle.DropDown : ComboBoxStyle.DropDownList;
    }

    public static void RemoveItem(int controlHandle, int index)
    {
        HandleManager.GetControl<System.Windows.Forms.ComboBox>(controlHandle).Items.RemoveAt(index);
    }
}

public static class ProgressBar
{
    public static void SetValue(int controlHandle, int value)
    {
        HandleManager.GetControl<System.Windows.Forms.ProgressBar>(controlHandle).Value = value;
    }

    public static int GetValue(int controlHandle)
    {
        return HandleManager.GetControl<System.Windows.Forms.ProgressBar>(controlHandle).Value;
    }

    public static void SetRange(int controlHandle, int min, int max)
    {
        var pb = HandleManager.GetControl<System.Windows.Forms.ProgressBar>(controlHandle);
        pb.Minimum = min;
        pb.Maximum = max;
    }

    public static (int min, int max) GetRange(int controlHandle)
    {
        var pb = HandleManager.GetControl<System.Windows.Forms.ProgressBar>(controlHandle);
        return (pb.Minimum, pb.Maximum);
    }
}

public static class PictureBox
{
    public static void LoadImage(int controlHandle, string imagePath)
    {
        HandleManager.GetControl<System.Windows.Forms.PictureBox>(controlHandle).Image = Image.FromFile(imagePath);
    }

    public static void SetSizeMode(int controlHandle, int mode)
    {
        HandleManager.GetControl<System.Windows.Forms.PictureBox>(controlHandle).SizeMode = (PictureBoxSizeMode)mode;
    }

    public static void ClearImage(int controlHandle)
    {
        var pb = HandleManager.GetControl<System.Windows.Forms.PictureBox>(controlHandle);
        pb.Image?.Dispose();
        pb.Image = null;
    }
}

public static class CheckBox
{
    public static void SetChecked(int controlHandle, bool isChecked)
    {
        HandleManager.GetControl<System.Windows.Forms.CheckBox>(controlHandle).Checked = isChecked;
    }

    public static bool IsChecked(int controlHandle)
    {
        return HandleManager.GetControl<System.Windows.Forms.CheckBox>(controlHandle).Checked;
    }

    public static void SetThreeState(int controlHandle, bool threeState)
    {
        HandleManager.GetControl<System.Windows.Forms.CheckBox>(controlHandle).ThreeState = threeState;
    }
}

public static class RadioButton
{
    public static void SetChecked(int controlHandle, bool isChecked)
    {
        HandleManager.GetControl<System.Windows.Forms.RadioButton>(controlHandle).Checked = isChecked;
    }

    public static bool IsChecked(int controlHandle)
    {
        return HandleManager.GetControl<System.Windows.Forms.RadioButton>(controlHandle).Checked;
    }

    public static void Group(int parentHandle)
    {
        var parent = HandleManager.GetControl(parentHandle);
        bool first = true;
        foreach (System.Windows.Forms.Control c in parent.Controls)
        {
            if (c is System.Windows.Forms.RadioButton rb)
            {
                rb.TabStop = first;
                first = false;
            }
        }
    }
}

public static class TextBox
{
    public static void SetReadOnly(int controlHandle, bool readOnly)
    {
        HandleManager.GetControl<System.Windows.Forms.TextBox>(controlHandle).ReadOnly = readOnly;
    }

    public static void SetPasswordChar(int controlHandle, char ch)
    {
        HandleManager.GetControl<System.Windows.Forms.TextBox>(controlHandle).PasswordChar = ch;
    }

    public static void SetMultiline(int controlHandle, bool multiline)
    {
        HandleManager.GetControl<System.Windows.Forms.TextBox>(controlHandle).Multiline = multiline;
    }

    public static void AppendText(int controlHandle, string text)
    {
        HandleManager.GetControl<System.Windows.Forms.TextBox>(controlHandle).AppendText(text);
    }

    public static void Clear(int controlHandle)
    {
        HandleManager.GetControl<System.Windows.Forms.TextBox>(controlHandle).Clear();
    }

    public static void SelectAll(int controlHandle)
    {
        HandleManager.GetControl<System.Windows.Forms.TextBox>(controlHandle).SelectAll();
    }
}

public static class RichText
{
    public static void AppendText(int controlHandle, string text)
    {
        HandleManager.GetControl<System.Windows.Forms.RichTextBox>(controlHandle).AppendText(text);
    }

    public static void Clear(int controlHandle)
    {
        HandleManager.GetControl<System.Windows.Forms.RichTextBox>(controlHandle).Clear();
    }

    public static void LoadFile(int controlHandle, string filePath)
    {
        HandleManager.GetControl<System.Windows.Forms.RichTextBox>(controlHandle).LoadFile(filePath);
    }

    public static string GetText(int controlHandle)
    {
        return HandleManager.GetControl<System.Windows.Forms.RichTextBox>(controlHandle).Text;
    }

    public static void SetText(int controlHandle, string text)
    {
        HandleManager.GetControl<System.Windows.Forms.RichTextBox>(controlHandle).Text = text;
    }

    public static void SetReadOnly(int controlHandle, bool readOnly)
    {
        HandleManager.GetControl<System.Windows.Forms.RichTextBox>(controlHandle).ReadOnly = readOnly;
    }
}

public static class NumericBox
{
    public static void SetValue(int controlHandle, decimal value)
    {
        HandleManager.GetControl<NumericUpDown>(controlHandle).Value = value;
    }

    public static decimal GetValue(int controlHandle)
    {
        return HandleManager.GetControl<NumericUpDown>(controlHandle).Value;
    }

    public static void SetRange(int controlHandle, decimal min, decimal max)
    {
        var nud = HandleManager.GetControl<NumericUpDown>(controlHandle);
        nud.Minimum = min;
        nud.Maximum = max;
    }

    public static void SetDecimalPlaces(int controlHandle, int places)
    {
        HandleManager.GetControl<NumericUpDown>(controlHandle).DecimalPlaces = places;
    }
}

public static class DatePicker
{
    public static void SetValue(int controlHandle, int year, int month, int day)
    {
        HandleManager.GetControl<DateTimePicker>(controlHandle).Value = new DateTime(year, month, day);
    }

    public static (int year, int month, int day) GetValue(int controlHandle)
    {
        var dt = HandleManager.GetControl<DateTimePicker>(controlHandle).Value;
        return (dt.Year, dt.Month, dt.Day);
    }

    public static void SetFormat(int controlHandle, int format)
    {
        HandleManager.GetControl<DateTimePicker>(controlHandle).Format = (DateTimePickerFormat)format;
    }

    public static void SetCustomFormat(int controlHandle, string format)
    {
        var dtp = HandleManager.GetControl<DateTimePicker>(controlHandle);
        dtp.Format = DateTimePickerFormat.Custom;
        dtp.CustomFormat = format;
    }
}

public static class MessageBox
{
    public static void Show(string text)
    {
        System.Windows.Forms.MessageBox.Show(text);
    }

    public static void Show(string text, string caption)
    {
        System.Windows.Forms.MessageBox.Show(text, caption);
    }

    public static int ShowYesNo(string text, string caption)
    {
        var result = System.Windows.Forms.MessageBox.Show(text, caption, MessageBoxButtons.YesNo);
        return result == DialogResult.Yes ? 1 : 0;
    }

    public static int ShowYesNoCancel(string text, string caption)
    {
        var result = System.Windows.Forms.MessageBox.Show(text, caption, MessageBoxButtons.YesNoCancel);
        return result switch
        {
            DialogResult.Yes => 1,
            DialogResult.No => 0,
            _ => -1
        };
    }

    public static int ShowOkCancel(string text, string caption)
    {
        var result = System.Windows.Forms.MessageBox.Show(text, caption, MessageBoxButtons.OKCancel);
        return result == DialogResult.OK ? 1 : 0;
    }

    public static void ShowError(string text, string caption)
    {
        System.Windows.Forms.MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void ShowWarning(string text, string caption)
    {
        System.Windows.Forms.MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public static void ShowInfo(string text, string caption)
    {
        System.Windows.Forms.MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
