# how-to-remove-the-control-border-in-.net-maui-treeview
This repository demonstrates how to remove the default focus border from the .NET MAUI TreeView (SfTreeView) control. It provides a sample implementation that disables the system focus visuals on Windows by setting the UseSystemFocusVisuals property to false, resulting in a cleaner and borderless TreeView appearance.

## Sample
You can remove the default focus border for the .NET MAUI TreeView control by setting the UseSystemFocusVisuals property of PlatformView to false.

### MainPage.xaml.cs

```csharp
treeView.Loaded += TreeView_Loaded; 

private void TreeView_Loaded(object? sender, Syncfusion.Maui.TreeView.TreeViewLoadedEventArgs e)
{
#if WINDOWS
    var nativeView = treeView.Handler!.PlatformView as Microsoft.UI.Xaml.FrameworkElement;
    if (nativeView != null)
    {
        nativeView.UseSystemFocusVisuals = false;
    }
#endif
}
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements).

Make sure that you have the compatible versions of [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/ ) with the Dot NET MAUI workload and [.NET Core SDK 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) or later version in your machine before starting to work on this project.

## Troubleshooting:
### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion® has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion® liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion®'s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion®'s samples.