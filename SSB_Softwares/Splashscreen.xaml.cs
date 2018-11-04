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
using System.Threading.Tasks;
using Windows.System.Threading;
using Windows.ApplicationModel.Core;
using Windows.UI.ViewManagement;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SSB_Softwares
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Splashscreen : Page
    {
        public Splashscreen()
        {
            this.InitializeComponent();
          /*  CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            var view = ApplicationView.GetForCurrentView();
            var titleBar = view.TitleBar;
            titleBar.BackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ForegroundColor = Windows.UI.Color.FromArgb(100, 40, 0, 20);
            titleBar.InactiveBackgroundColor = Windows.UI.Color.FromArgb(100, 40, 0, 20);
            titleBar.InactiveForegroundColor = Windows.UI.Color.FromArgb(100, 40, 0, 20);
            titleBar.ButtonBackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ButtonHoverBackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ButtonPressedBackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ButtonInactiveBackgroundColor = Windows.UI.Color.FromArgb(100, 40, 0, 20);
            titleBar.ButtonForegroundColor = Windows.UI.Color.FromArgb(100, 40, 0, 20);
            titleBar.ButtonHoverForegroundColor = Windows.UI.Color.FromArgb(100, 40, 0, 20);
            titleBar.ButtonPressedForegroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ButtonInactiveForegroundColor = Windows.UI.Color.FromArgb(100, 40, 0, 20);*/
        }
        private async void LoadSomething()
        {
            await Task.Delay(3000);
            this.Frame.Navigate(typeof(MainPage));
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            LoadSomething();
            
        }
    }
}
