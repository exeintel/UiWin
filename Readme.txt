================================================================================
  UIwin v1.0.0 - Windows GUI Library
  Developer: ExEintel
  Target: .NET 10 | Windows Only
================================================================================

DESCRIPTION
  UIwin is a lightweight Windows GUI library built on .NET 10 / Windows Forms.
  It provides a simple, flat, procedural API for creating graphical user
  interfaces without requiring object-oriented programming knowledge.
  
  The library is designed for developers who want to create native Windows
  GUIs from any language that can interop with .NET, including C, Python,
  and other non-OOP languages.

REQUIREMENTS
  - Windows 10 / Windows 11
  - .NET 10 Runtime (https://dotnet.microsoft.com/download)
  - To compile: .NET 10 SDK + Visual Studio or dotnet CLI

STRUCTURE
  UIwin/
    UIwin.dll      - Compiled library (reference this in your project)
    Readme.txt     - This file
    sourse/        - Source code
      UIwin.slnx   - Solution file
      UIwin/
        UIwin.csproj    - Project file
        Core.cs         - Application and Window classes
        Controls.cs     - Control creation and management
        Widgets.cs      - Specialized widget methods and MessageBox
        Events.cs       - Event handling
        Internals.cs    - Internal handle management

QUICK START (C# without OOP)
  using UIwin;

  int hwnd = Window.Create("My App", 800, 600);
  int btn = Controls.CreateButton(hwnd, "Click Me", 10, 10, 100, 30);
  Events.SetClick(btn, () => MessageBox.Show("Hello!", "Info"));
  Application.Run(hwnd);

API REFERENCE

=== Application ===
  void    Application.Run(int windowHandle)
          - Starts the Windows message loop with the specified window.
            Blocks until the window is closed.
  void    Application.Exit()
          - Exits the application message loop.
  void    Application.DoEvents()
          - Processes pending Windows messages.

=== Window ===
  int     Window.Create(string title, int width, int height)
          - Creates a new window centered on screen. Returns handle.
  int     Window.Create(string title, int x, int y, int w, int h)
          - Creates a window at a specific position.
  void    Window.Show(int hwnd)
  void    Window.Hide(int hwnd)
  void    Window.Close(int hwnd)
  void    Window.SetTitle(int hwnd, string title)
  string  Window.GetTitle(int hwnd)
  void    Window.SetSize(int hwnd, int width, int height)
  (w,h)   Window.GetSize(int hwnd)
  void    Window.SetPosition(int hwnd, int x, int y)
  (x,y)   Window.GetPosition(int hwnd)
  void    Window.SetResizable(int hwnd, bool resizable)
  void    Window.CenterToScreen(int hwnd)
  void    Window.SetMinimumSize(int hwnd, int width, int height)
  void    Window.SetMaximumSize(int hwnd, int width, int height)

=== Controls (creation) ===
  int     Controls.CreateButton(int parent, string text, int x, int y, int w, int h)
  int     Controls.CreateLabel(int parent, string text, int x, int y, int w, int h)
  int     Controls.CreateTextBox(int parent, int x, int y, int w, int h)
  int     Controls.CreateCheckBox(int parent, string text, int x, int y, int w, int h)
  int     Controls.CreateRadioButton(int parent, string text, int x, int y, int w, int h)
  int     Controls.CreateListBox(int parent, int x, int y, int w, int h)
  int     Controls.CreateComboBox(int parent, int x, int y, int w, int h)
  int     Controls.CreateProgressBar(int parent, int x, int y, int w, int h)
  int     Controls.CreatePictureBox(int parent, int x, int y, int w, int h)
  int     Controls.CreateGroupBox(int parent, string text, int x, int y, int w, int h)
  int     Controls.CreateNumericBox(int parent, int x, int y, int w, int h)
  int     Controls.CreateDatePicker(int parent, int x, int y, int w, int h)
  int     Controls.CreatePanel(int parent, int x, int y, int w, int h)
  int     Controls.CreateRichTextBox(int parent, int x, int y, int w, int h)
  
  'parent' is the handle of the window or GroupBox/Panel that will contain
  the new control.

=== Control (common operations) ===
  void    Control.SetText(int ctrl, string text)
  string  Control.GetText(int ctrl)
  void    Control.SetEnabled(int ctrl, bool enabled)
  bool    Control.IsEnabled(int ctrl)
  void    Control.SetVisible(int ctrl, bool visible)
  bool    Control.IsVisible(int ctrl)
  void    Control.SetSize(int ctrl, int w, int h)
  (w,h)   Control.GetSize(int ctrl)
  void    Control.SetPosition(int ctrl, int x, int y)
  (x,y)   Control.GetPosition(int ctrl)
  void    Control.SetFont(int ctrl, string fontName, int fontSize)
  void    Control.SetFontBold(int ctrl, string fontName, int fontSize)
  void    Control.SetBackColor(int ctrl, int r, int g, int b)
  void    Control.SetForeColor(int ctrl, int r, int g, int b)
  void    Control.Focus(int ctrl)
  void    Control.Destroy(int ctrl)       - removes and disposes control
  void    Control.SetAnchor(int ctrl, int left, int top, int right, int bottom)
  void    Control.SetDock(int ctrl, int dock)
  void    Control.BringToFront(int ctrl)
  void    Control.SendToBack(int ctrl)
  int     Control.GetTypeCode(int ctrl)   - returns numeric type ID

=== ListBox ===
  void    ListBox.AddItem(int ctrl, string item)
  void    ListBox.Clear(int ctrl)
  int     ListBox.GetSelectedIndex(int ctrl)
  string  ListBox.GetSelectedItem(int ctrl)
  void    ListBox.SetSelectedIndex(int ctrl, int index)
  int     ListBox.GetItemCount(int ctrl)
  void    ListBox.RemoveItem(int ctrl, int index)

=== ComboBox ===
  void    ComboBox.AddItem(int ctrl, string item)
  void    ComboBox.Clear(int ctrl)
  int     ComboBox.GetSelectedIndex(int ctrl)
  string  ComboBox.GetSelectedItem(int ctrl)
  void    ComboBox.SetSelectedIndex(int ctrl, int index)
  int     ComboBox.GetItemCount(int ctrl)
  void    ComboBox.SetEditable(int ctrl, bool editable)
  void    ComboBox.RemoveItem(int ctrl, int index)

=== CheckBox ===
  void    CheckBox.SetChecked(int ctrl, bool isChecked)
  bool    CheckBox.IsChecked(int ctrl)
  void    CheckBox.SetThreeState(int ctrl, bool threeState)

=== RadioButton ===
  void    RadioButton.SetChecked(int ctrl, bool isChecked)
  bool    RadioButton.IsChecked(int ctrl)
  void    RadioButton.Group(int parentHandle)

=== TextBox ===
  void    TextBox.SetReadOnly(int ctrl, bool readOnly)
  void    TextBox.SetPasswordChar(int ctrl, char ch)
  void    TextBox.SetMultiline(int ctrl, bool multiline)
  void    TextBox.AppendText(int ctrl, string text)
  void    TextBox.Clear(int ctrl)
  void    TextBox.SelectAll(int ctrl)

=== RichText ===
  void    RichText.AppendText(int ctrl, string text)
  void    RichText.Clear(int ctrl)
  void    RichText.LoadFile(int ctrl, string filePath)
  string  RichText.GetText(int ctrl)
  void    RichText.SetText(int ctrl, string text)
  void    RichText.SetReadOnly(int ctrl, bool readOnly)

=== ProgressBar ===
  void    ProgressBar.SetValue(int ctrl, int value)
  int     ProgressBar.GetValue(int ctrl)
  void    ProgressBar.SetRange(int ctrl, int min, int max)

=== NumericBox (NumericUpDown) ===
  void    NumericBox.SetValue(int ctrl, decimal value)
  decimal NumericBox.GetValue(int ctrl)
  void    NumericBox.SetRange(int ctrl, decimal min, decimal max)
  void    NumericBox.SetDecimalPlaces(int ctrl, int places)

=== DatePicker (DateTimePicker) ===
  void    DatePicker.SetValue(int ctrl, int year, int month, int day)
  (y,m,d) DatePicker.GetValue(int ctrl)
  void    DatePicker.SetFormat(int ctrl, int format)
  void    DatePicker.SetCustomFormat(int ctrl, string format)

=== PictureBox ===
  void    PictureBox.LoadImage(int ctrl, string imagePath)
  void    PictureBox.SetSizeMode(int ctrl, int mode)
          mode: 0=Normal, 1=StretchImage, 2=AutoSize, 3=CenterImage, 4=Zoom
  void    PictureBox.ClearImage(int ctrl)

=== Events (callbacks) ===
  void    Events.SetClick(int ctrl, Action callback)
  void    Events.RemoveClick(int ctrl)
  void    Events.SetTextChanged(int ctrl, Action<string> callback)
  void    Events.RemoveTextChanged(int ctrl)
  void    Events.SetSelectedIndexChanged(int ctrl, Action<int> callback)
  void    Events.RemoveSelectedIndexChanged(int ctrl)
  void    Events.SetCheckedChanged(int ctrl, Action<bool> callback)
  void    Events.SetMouseClick(int ctrl, Action<int,int> callback)  // x,y
  void    Events.SetKeyPress(int ctrl, Action<char> callback)
  void    Events.SetValueChanged(int ctrl, Action<decimal> callback)
  void    Events.SetFormClosed(int hwnd, Action callback)
  void    Events.SetFormClosing(int hwnd, Func<bool> callback)
          - Return true to allow close, false to cancel.
  void    Events.SetFormLoad(int hwnd, Action callback)
  void    Events.SetFormShown(int hwnd, Action callback)
  void    Events.ClearAllEvents(int ctrl)

=== MessageBox (message dialogs) ===
  void    MessageBox.Show(string text)
  void    MessageBox.Show(string text, string caption)
  int     MessageBox.ShowYesNo(string text, string caption)
          Returns: 1=Yes, 0=No
  int     MessageBox.ShowYesNoCancel(string text, string caption)
          Returns: 1=Yes, 0=No, -1=Cancel
  int     MessageBox.ShowOkCancel(string text, string caption)
          Returns: 1=OK, 0=Cancel
  void    MessageBox.ShowError(string text, string caption)
  void    MessageBox.ShowWarning(string text, string caption)
  void    MessageBox.ShowInfo(string text, string caption)

USING FROM C (P/Invoke)
  To use UIwin.dll from C or other unmanaged languages:
  - Your program must host the .NET 10 runtime
  - Use LoadLibrary/GetProcAddress to load the DLL
  - All functions require [STAThread] on the calling thread
  - Pass string parameters as Unicode (UTF-16) pointers
  
  Example C workflow:
    1. Create a C++/CLI wrapper that references UIwin.dll
    2. Export flat C functions from the wrapper
    3. Call them from your C code

  Alternatively, compile your .NET code as a NativeAOT DLL with
  UnmanagedCallersOnly exports for direct C interop.

THREADING NOTES
  - All UI operations must run on the same thread.
  - The thread must be STA (Single-Threaded Apartment).
  - Call Application.Run(windowHandle) to start the message loop.
  - After Run() is called, event callbacks execute on the UI thread.
  - Use Application.DoEvents() to keep the UI responsive during
    long operations (alternative: use System.Threading.Tasks).

EXAMPLE (Full C# program)
  using UIwin;
  
  int mainHwnd = Window.Create("Calculator", 300, 200);
  Window.SetResizable(mainHwnd, false);
  
  int lbl = Controls.CreateLabel(mainHwnd, "Enter number:", 10, 10, 280, 20);
  int numBox = Controls.CreateNumericBox(mainHwnd, 10, 35, 280, 25);
  
  int btnSqrt = Controls.CreateButton(mainHwnd, "Square Root", 10, 70, 130, 30);
  int btnSquare = Controls.CreateButton(mainHwnd, "Square", 160, 70, 130, 30);
  int resultLbl = Controls.CreateLabel(mainHwnd, "Result: ", 10, 110, 280, 20);
  
  Events.SetClick(btnSqrt, () => {
      double val = (double)NumericBox.GetValue(numBox);
      NumericBox.SetValue(numBox, (decimal)Math.Sqrt(val));
  });
  
  Events.SetClick(btnSquare, () => {
      double val = (double)NumericBox.GetValue(numBox);
      NumericBox.SetValue(numBox, (decimal)(val * val));
  });
  
  Events.SetFormClosed(mainHwnd, () => Application.Exit());
  Application.Run(mainHwnd);

BUILD FROM SOURCE
  cd sourse
  dotnet build -c Release
  The compiled DLL will be at: UIwin/bin/Release/net10.0-windows/UIwin.dll

LICENSE
  MIT License - Free to use, modify, and distribute.
================================================================================
