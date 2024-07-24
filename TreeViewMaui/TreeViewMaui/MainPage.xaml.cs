namespace TreeViewMaui
{
    public partial class MainPage : ContentPage
    {    
        public MainPage()
        {
            InitializeComponent();
            treeView.Loaded += TreeView_Loaded;
        }
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
    }

}
