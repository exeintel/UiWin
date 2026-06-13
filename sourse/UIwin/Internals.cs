namespace UIwin;

internal static class HandleManager
{
    private static readonly Dictionary<int, System.Windows.Forms.Control> _controls = new();
    private static int _nextHandle = 1;

    public static int Register(System.Windows.Forms.Control control)
    {
        int handle = _nextHandle++;
        _controls[handle] = control;
        return handle;
    }

    public static void Unregister(int handle)
    {
        _controls.Remove(handle);
    }

    public static System.Windows.Forms.Control GetControl(int handle)
    {
        if (_controls.TryGetValue(handle, out var control))
            return control;
        throw new ArgumentException($"Invalid control handle: {handle}");
    }

    public static T GetControl<T>(int handle) where T : System.Windows.Forms.Control
    {
        return (T)GetControl(handle);
    }

    public static Form GetForm(int handle)
    {
        return GetControl<Form>(handle);
    }

    public static bool Exists(int handle)
    {
        return _controls.ContainsKey(handle);
    }
}
