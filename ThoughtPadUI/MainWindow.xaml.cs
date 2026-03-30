using Microsoft.UI.Xaml;

using Microsoft.UI.Windowing;

using Windows.UI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ThoughtPadUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetTitleBarTheme();

            RootFrame.Navigate(typeof(Pages.MainPage));
        }


        private void SetTitleBarTheme()
        {
            var hwnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            var windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hwnd);
            var appWindow = AppWindow.GetFromWindowId(windowId);

            if (appWindow.TitleBar is not null)
            {
                var dark = Color.FromArgb(255, 32, 32, 32);
                var white = Color.FromArgb(255, 255, 255, 255);

                appWindow.TitleBar.BackgroundColor = dark;
                appWindow.TitleBar.ForegroundColor = white;

                appWindow.TitleBar.ButtonBackgroundColor = dark;
                appWindow.TitleBar.ButtonForegroundColor = white;

                appWindow.TitleBar.ButtonHoverBackgroundColor = Color.FromArgb(255, 50, 50, 50);
            }
        }
    }
}
