namespace UIwin;

public static class Events
{
    private static readonly Dictionary<int, Delegate> _handlers = new();

    private static int EventKey(int handle, int eventId) => handle * 1000 + eventId;

    public static void SetClick(int controlHandle, Action callback)
    {
        var btn = HandleManager.GetControl<Button>(controlHandle);
        EventHandler handler = (_, _) => callback();
        btn.Click += handler;
        _handlers[EventKey(controlHandle, 1)] = handler;
    }

    public static void RemoveClick(int controlHandle)
    {
        if (_handlers.TryGetValue(EventKey(controlHandle, 1), out var handler))
        {
            HandleManager.GetControl<Button>(controlHandle).Click -= (EventHandler)handler;
            _handlers.Remove(EventKey(controlHandle, 1));
        }
    }

    public static void SetTextChanged(int controlHandle, Action<string> callback)
    {
        var tb = HandleManager.GetControl<System.Windows.Forms.TextBox>(controlHandle);
        EventHandler handler = (_, _) => callback(tb.Text);
        tb.TextChanged += handler;
        _handlers[EventKey(controlHandle, 2)] = handler;
    }

    public static void RemoveTextChanged(int controlHandle)
    {
        if (_handlers.TryGetValue(EventKey(controlHandle, 2), out var handler))
        {
            HandleManager.GetControl<System.Windows.Forms.TextBox>(controlHandle).TextChanged -= (EventHandler)handler;
            _handlers.Remove(EventKey(controlHandle, 2));
        }
    }

    public static void SetSelectedIndexChanged(int controlHandle, Action<int> callback)
    {
        var control = HandleManager.GetControl(controlHandle);
        EventHandler handler = null!;
        if (control is System.Windows.Forms.ListBox lb)
            handler = (_, _) => callback(lb.SelectedIndex);
        else if (control is System.Windows.Forms.ComboBox cb)
            handler = (_, _) => callback(cb.SelectedIndex);
        else
            throw new ArgumentException("Control is not a ListBox or ComboBox");

        if (control is System.Windows.Forms.ListBox lb2)
            lb2.SelectedIndexChanged += handler;
        else if (control is System.Windows.Forms.ComboBox cb2)
            cb2.SelectedIndexChanged += handler;

        _handlers[EventKey(controlHandle, 3)] = handler;
    }

    public static void RemoveSelectedIndexChanged(int controlHandle)
    {
        if (_handlers.TryGetValue(EventKey(controlHandle, 3), out var handler))
        {
            var control = HandleManager.GetControl(controlHandle);
            if (control is System.Windows.Forms.ListBox lb)
                lb.SelectedIndexChanged -= (EventHandler)handler;
            else if (control is System.Windows.Forms.ComboBox cb)
                cb.SelectedIndexChanged -= (EventHandler)handler;
            _handlers.Remove(EventKey(controlHandle, 3));
        }
    }

    public static void SetCheckedChanged(int controlHandle, Action<bool> callback)
    {
        var cb = HandleManager.GetControl<System.Windows.Forms.CheckBox>(controlHandle);
        EventHandler handler = (_, _) => callback(cb.Checked);
        cb.CheckedChanged += handler;
        _handlers[EventKey(controlHandle, 4)] = handler;
    }

    public static void SetMouseClick(int controlHandle, Action<int, int> callback)
    {
        var control = HandleManager.GetControl(controlHandle);
        MouseEventHandler handler = (_, e) => callback(e.X, e.Y);
        control.MouseClick += handler;
        _handlers[EventKey(controlHandle, 5)] = handler;
    }

    public static void SetKeyPress(int controlHandle, Action<char> callback)
    {
        var control = HandleManager.GetControl(controlHandle);
        KeyPressEventHandler handler = (_, e) => callback(e.KeyChar);
        control.KeyPress += handler;
        _handlers[EventKey(controlHandle, 6)] = handler;
    }

    public static void SetValueChanged(int controlHandle, Action<decimal> callback)
    {
        var nud = HandleManager.GetControl<NumericUpDown>(controlHandle);
        EventHandler handler = (_, e) => callback(nud.Value);
        nud.ValueChanged += handler;
        _handlers[EventKey(controlHandle, 7)] = handler;
    }

    public static void SetFormClosed(int windowHandle, Action callback)
    {
        var form = HandleManager.GetForm(windowHandle);
        FormClosedEventHandler handler = (_, _) => callback();
        form.FormClosed += handler;
        _handlers[EventKey(windowHandle, 10)] = handler;
    }

    public static void SetFormClosing(int windowHandle, Func<bool> callback)
    {
        var form = HandleManager.GetForm(windowHandle);
        FormClosingEventHandler handler = (_, e) => e.Cancel = !callback();
        form.FormClosing += handler;
        _handlers[EventKey(windowHandle, 11)] = handler;
    }

    public static void SetFormLoad(int windowHandle, Action callback)
    {
        var form = HandleManager.GetForm(windowHandle);
        EventHandler handler = (_, _) => callback();
        form.Load += handler;
        _handlers[EventKey(windowHandle, 12)] = handler;
    }

    public static void SetFormShown(int windowHandle, Action callback)
    {
        var form = HandleManager.GetForm(windowHandle);
        EventHandler handler = (_, _) => callback();
        form.Shown += handler;
        _handlers[EventKey(windowHandle, 13)] = handler;
    }

    public static void ClearAllEvents(int controlHandle)
    {
        var keysToRemove = _handlers.Keys.Where(k => k / 1000 == controlHandle).ToList();
        foreach (var key in keysToRemove)
            _handlers.Remove(key);
    }
}
