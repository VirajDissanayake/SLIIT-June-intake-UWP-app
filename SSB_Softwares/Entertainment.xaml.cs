using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SSB_Softwares
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Entertainment : Page
    {
        public Entertainment()
        {
            this.InitializeComponent();
        }

        private void Kdrama(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Video));
            ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
        }
        private void Menu(object sender, RoutedEventArgs e)
        {
            menu1.IsPaneOpen = true;
        }

        private void On_Hover(object sender, PointerRoutedEventArgs e)
        {
            menu1.IsPaneOpen = true;
        }

        private void Off_Hover(object sender, PointerRoutedEventArgs e)
        {
            menu1.IsPaneOpen = false;
        }
        private void Home(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
            ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
        }

        private void Tv(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Tv));
            ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
        }

        private void Google(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(google));
            ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
        }
    }
}
