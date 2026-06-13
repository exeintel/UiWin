namespace UIwin;

public static class Application
{
    public static void Run(int windowHandle)
    {
        var form = HandleManager.GetForm(windowHandle);
        System.Windows.Forms.Application.Run(form);
    }

    public static void Exit()
    {
        System.Windows.Forms.Application.Exit();
    }

    public static void DoEvents()
    {
        System.Windows.Forms.Application.DoEvents();
    }
}

public static class Window
{
    public static int Create(string title, int width, int height)
    {
        var form = new Form
        {
            Text = title,
            Size = new Size(width, height),
            StartPosition = FormStartPosition.CenterScreen
        };
        return HandleManager.Register(form);
    }

    public static int Create(string title, int x, int y, int width, int height)
    {
        var form = new Form
        {
            Text = title,
            Location = new Point(x, y),
            Size = new Size(width, height),
            StartPosition = FormStartPosition.Manual
        };
        return HandleManager.Register(form);
    }

    public static void Show(int windowHandle)
    {
        HandleManager.GetForm(windowHandle).Show();
    }

    public static void Hide(int windowHandle)
    {
        HandleManager.GetForm(windowHandle).Hide();
    }

    public static void Close(int windowHandle)
    {
        var form = HandleManager.GetForm(windowHandle);
        int h = windowHandle;
        form.FormClosed += (_, _) => HandleManager.Unregister(h);
        form.Close();
    }

    public static void SetTitle(int windowHandle, string title)
    {
        HandleManager.GetForm(windowHandle).Text = title;
    }

    public static string GetTitle(int windowHandle)
    {
        return HandleManager.GetForm(windowHandle).Text;
    }

    public static void SetSize(int windowHandle, int width, int height)
    {
        HandleManager.GetForm(windowHandle).Size = new Size(width, height);
    }

    public static (int width, int height) GetSize(int windowHandle)
    {
        var f = HandleManager.GetForm(windowHandle);
        return (f.Width, f.Height);
    }

    public static void SetPosition(int windowHandle, int x, int y)
    {
        HandleManager.GetForm(windowHandle).Location = new Point(x, y);
    }

    public static (int x, int y) GetPosition(int windowHandle)
    {
        var f = HandleManager.GetForm(windowHandle);
        return (f.Left, f.Top);
    }

    public static void SetResizable(int windowHandle, bool resizable)
    {
        HandleManager.GetForm(windowHandle).FormBorderStyle =
            resizable ? FormBorderStyle.Sizable : FormBorderStyle.FixedSingle;
    }

    public static void CenterToScreen(int windowHandle)
    {
        var form = HandleManager.GetForm(windowHandle);
        form.StartPosition = FormStartPosition.CenterScreen;
    }

    public static void SetMinimumSize(int windowHandle, int width, int height)
    {
        HandleManager.GetForm(windowHandle).MinimumSize = new Size(width, height);
    }

    public static void SetMaximumSize(int windowHandle, int width, int height)
    {
        HandleManager.GetForm(windowHandle).MaximumSize = new Size(width, height);
    }
}
