using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.ViewManagement;
using Windows.UI;
using Windows.ApplicationModel.Core;
using AIUB_Companion.Views;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AIUB_Companion
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            AcrylicTitleBar();
        }
        void AcrylicTitleBar()
        {
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            var title = ApplicationView.GetForCurrentView();
            title.TitleBar.ButtonBackgroundColor = Colors.Transparent;
            title.TitleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
            title.TitleBar.ButtonForegroundColor = (Color)Resources["SystemBaseHighColor"];
        }

        private void _onTapHome(object sender, TappedRoutedEventArgs e)
        {
            PageFrame.Navigate(typeof(HomePage));
        }

        private void _onTapNotice(object sender, TappedRoutedEventArgs e)
        {
            PageFrame.Navigate(typeof(NoticePage));
        }
    }
}
