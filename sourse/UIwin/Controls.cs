namespace UIwin;

public static class Controls
{
    public static int CreateButton(int parentHandle, string text, int x, int y, int width, int height)
    {
        var btn = new System.Windows.Forms.Button
        {
            Text = text,
            Location = new Point(x, y),
            Size = new Size(width, height),
            FlatStyle = FlatStyle.System,
            UseVisualStyleBackColor = true
        };
        HandleManager.GetControl(parentHandle).Controls.Add(btn);
        return HandleManager.Register(btn);
    }

    public static int CreateLabel(int parentHandle, string text, int x, int y, int width, int height)
    {
        var lbl = new System.Windows.Forms.Label
        {
            Text = text,
            Location = new Point(x, y),
            Size = new Size(width, height),
            AutoSize = false
        };
        HandleManager.GetControl(parentHandle).Controls.Add(lbl);
        return HandleManager.Register(lbl);
    }

    public static int CreateTextBox(int parentHandle, int x, int y, int width, int height)
    {
        var tb = new System.Windows.Forms.TextBox
        {
            Location = new Point(x, y),
            Size = new Size(width, height)
        };
        HandleManager.GetControl(parentHandle).Controls.Add(tb);
        return HandleManager.Register(tb);
    }

    public static int CreateCheckBox(int parentHandle, string text, int x, int y, int width, int height)
    {
        var cb = new System.Windows.Forms.CheckBox
        {
            Text = text,
            Location = new Point(x, y),
            Size = new Size(width, height),
            UseVisualStyleBackColor = true
        };
        HandleManager.GetControl(parentHandle).Controls.Add(cb);
        return HandleManager.Register(cb);
    }

    public static int CreateRadioButton(int parentHandle, string text, int x, int y, int width, int height)
    {
        var rb = new System.Windows.Forms.RadioButton
        {
            Text = text,
            Location = new Point(x, y),
            Size = new Size(width, height),
            UseVisualStyleBackColor = true
        };
        HandleManager.GetControl(parentHandle).Controls.Add(rb);
        return HandleManager.Register(rb);
    }

    public static int CreateListBox(int parentHandle, int x, int y, int width, int height)
    {
        var lb = new System.Windows.Forms.ListBox
        {
            Location = new Point(x, y),
            Size = new Size(width, height)
        };
        HandleManager.GetControl(parentHandle).Controls.Add(lb);
        return HandleManager.Register(lb);
    }

    public static int CreateComboBox(int parentHandle, int x, int y, int width, int height)
    {
        var cb = new System.Windows.Forms.ComboBox
        {
            Location = new Point(x, y),
            Size = new Size(width, height),
            DropDownStyle = ComboBoxStyle.DropDownList
        };
        HandleManager.GetControl(parentHandle).Controls.Add(cb);
        return HandleManager.Register(cb);
    }

    public static int CreateProgressBar(int parentHandle, int x, int y, int width, int height)
    {
        var pb = new System.Windows.Forms.ProgressBar
        {
            Location = new Point(x, y),
            Size = new Size(width, height),
            Minimum = 0,
            Maximum = 100,
            Value = 0
        };
        HandleManager.GetControl(parentHandle).Controls.Add(pb);
        return HandleManager.Register(pb);
    }

    public static int CreatePictureBox(int parentHandle, int x, int y, int width, int height)
    {
        var pb = new System.Windows.Forms.PictureBox
        {
            Location = new Point(x, y),
            Size = new Size(width, height),
            SizeMode = PictureBoxSizeMode.Normal
        };
        HandleManager.GetControl(parentHandle).Controls.Add(pb);
        return HandleManager.Register(pb);
    }

    public static int CreateGroupBox(int parentHandle, string text, int x, int y, int width, int height)
    {
        var gb = new System.Windows.Forms.GroupBox
        {
            Text = text,
            Location = new Point(x, y),
            Size = new Size(width, height)
        };
        HandleManager.GetControl(parentHandle).Controls.Add(gb);
        return HandleManager.Register(gb);
    }

    public static int CreateNumericBox(int parentHandle, int x, int y, int width, int height)
    {
        var nud = new NumericUpDown
        {
            Location = new Point(x, y),
            Size = new Size(width, height),
            Minimum = 0,
            Maximum = 100,
            Value = 0
        };
        HandleManager.GetControl(parentHandle).Controls.Add(nud);
        return HandleManager.Register(nud);
    }

    public static int CreateDatePicker(int parentHandle, int x, int y, int width, int height)
    {
        var dtp = new DateTimePicker
        {
            Location = new Point(x, y),
            Size = new Size(width, height)
        };
        HandleManager.GetControl(parentHandle).Controls.Add(dtp);
        return HandleManager.Register(dtp);
    }

    public static int CreatePanel(int parentHandle, int x, int y, int width, int height)
    {
        var pnl = new System.Windows.Forms.Panel
        {
            Location = new Point(x, y),
            Size = new Size(width, height)
        };
        HandleManager.GetControl(parentHandle).Controls.Add(pnl);
        return HandleManager.Register(pnl);
    }

    public static int CreateRichTextBox(int parentHandle, int x, int y, int width, int height)
    {
        var rtb = new System.Windows.Forms.RichTextBox
        {
            Location = new Point(x, y),
            Size = new Size(width, height)
        };
        HandleManager.GetControl(parentHandle).Controls.Add(rtb);
        return HandleManager.Register(rtb);
    }
}

public static class Control
{
    public static void SetText(int controlHandle, string text)
    {
        HandleManager.GetControl(controlHandle).Text = text;
    }

    public static string GetText(int controlHandle)
    {
        return HandleManager.GetControl(controlHandle).Text;
    }

    public static void SetEnabled(int controlHandle, bool enabled)
    {
        HandleManager.GetControl(controlHandle).Enabled = enabled;
    }

    public static bool IsEnabled(int controlHandle)
    {
        return HandleManager.GetControl(controlHandle).Enabled;
    }

    public static void SetVisible(int controlHandle, bool visible)
    {
        HandleManager.GetControl(controlHandle).Visible = visible;
    }

    public static bool IsVisible(int controlHandle)
    {
        return HandleManager.GetControl(controlHandle).Visible;
    }

    public static void SetSize(int controlHandle, int width, int height)
    {
        HandleManager.GetControl(controlHandle).Size = new Size(width, height);
    }

    public static (int width, int height) GetSize(int controlHandle)
    {
        var c = HandleManager.GetControl(controlHandle);
        return (c.Width, c.Height);
    }

    public static void SetPosition(int controlHandle, int x, int y)
    {
        HandleManager.GetControl(controlHandle).Location = new Point(x, y);
    }

    public static (int x, int y) GetPosition(int controlHandle)
    {
        var c = HandleManager.GetControl(controlHandle);
        return (c.Left, c.Top);
    }

    public static void SetFont(int controlHandle, string fontName, int fontSize)
    {
        HandleManager.GetControl(controlHandle).Font = new Font(fontName, fontSize, FontStyle.Regular);
    }

    public static void SetFontBold(int controlHandle, string fontName, int fontSize)
    {
        HandleManager.GetControl(controlHandle).Font = new Font(fontName, fontSize, FontStyle.Bold);
    }

    public static void SetBackColor(int controlHandle, int r, int g, int b)
    {
        HandleManager.GetControl(controlHandle).BackColor = Color.FromArgb(r, g, b);
    }

    public static void SetForeColor(int controlHandle, int r, int g, int b)
    {
        HandleManager.GetControl(controlHandle).ForeColor = Color.FromArgb(r, g, b);
    }

    public static void Focus(int controlHandle)
    {
        HandleManager.GetControl(controlHandle).Focus();
    }

    public static void Destroy(int controlHandle)
    {
        var ctrl = HandleManager.GetControl(controlHandle);
        ctrl.Parent?.Controls.Remove(ctrl);
        ctrl.Dispose();
        HandleManager.Unregister(controlHandle);
    }

    public static void SetAnchor(int controlHandle, int left, int top, int right, int bottom)
    {
        var styles = AnchorStyles.None;
        if (left != 0) styles |= AnchorStyles.Left;
        if (top != 0) styles |= AnchorStyles.Top;
        if (right != 0) styles |= AnchorStyles.Right;
        if (bottom != 0) styles |= AnchorStyles.Bottom;
        HandleManager.GetControl(controlHandle).Anchor = styles;
    }

    public static void SetDock(int controlHandle, int dock)
    {
        HandleManager.GetControl(controlHandle).Dock = (DockStyle)dock;
    }

    public static void BringToFront(int controlHandle)
    {
        HandleManager.GetControl(controlHandle).BringToFront();
    }

    public static void SendToBack(int controlHandle)
    {
        HandleManager.GetControl(controlHandle).SendToBack();
    }

    public static int GetTypeCode(int controlHandle)
    {
        return HandleManager.GetControl(controlHandle).GetType().Name switch
        {
            "Button" => 1,
            "Label" => 2,
            "TextBox" => 3,
            "CheckBox" => 4,
            "RadioButton" => 5,
            "ListBox" => 6,
            "ComboBox" => 7,
            "ProgressBar" => 8,
            "PictureBox" => 9,
            "GroupBox" => 10,
            "NumericUpDown" => 11,
            "DateTimePicker" => 12,
            "Panel" => 13,
            "RichTextBox" => 14,
            "Form" => 100,
            _ => 0
        };
    }
}
