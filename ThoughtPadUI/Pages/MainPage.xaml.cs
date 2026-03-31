using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Windows.Storage.Pickers;

using System;
using System.Diagnostics;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ThoughtPadUI.Pages;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void TestButton_Click(object sender, RoutedEventArgs e)
    {
        var enterPasswordDialog = new EnterPasswordDialog();
        enterPasswordDialog.XamlRoot = this.XamlRoot;
        var result = await enterPasswordDialog.ShowAsync();
        Debug.WriteLine(result);

        var fileOpenPicker = new FileOpenPicker(App.MainWindow.AppWindow.Id);
        fileOpenPicker.FileTypeFilter.Add(".db");
        fileOpenPicker.FileTypeFilter.Add("*");
        var pickedFile = await fileOpenPicker.PickSingleFileAsync();

        Debug.WriteLine(pickedFile?.Path ?? "none");
    }
}
