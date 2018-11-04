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
using Windows.ApplicationModel.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SSB_Softwares
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class dccn2 : Page
    {
        public dccn2()
        {
            this.InitializeComponent();
           /* CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            var view = ApplicationView.GetForCurrentView();
            var titleBar = view.TitleBar;

            titleBar.BackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ForegroundColor = Windows.UI.Color.FromArgb(100, 67, 0, 62);
            titleBar.InactiveBackgroundColor = Windows.UI.Color.FromArgb(100, 67, 0, 62);
            titleBar.InactiveForegroundColor = Windows.UI.Color.FromArgb(100, 67, 0, 62);
            titleBar.ButtonBackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ButtonHoverBackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ButtonPressedBackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ButtonInactiveBackgroundColor = Windows.UI.Color.FromArgb(100, 67, 0, 62);
            titleBar.ButtonForegroundColor = Windows.UI.Color.FromArgb(100, 67, 0, 62);
            titleBar.ButtonHoverForegroundColor = Windows.UI.Color.FromArgb(100, 67, 0, 62);
            titleBar.ButtonPressedForegroundColor = Windows.UI.Color.FromArgb(100, 67, 0, 62);
            titleBar.ButtonInactiveForegroundColor = Windows.UI.Color.FromArgb(100, 67, 0, 62);*/
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

        private void Exit(object sender, RoutedEventArgs e)
        {
            CoreApplication.Exit();
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Modules(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Modules));
        }
        private void Online(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://drive.google.com/open?id=1AvK3UqIWXrTt3UqMg8q2Kh5AY1ly9sRO");
            w3.Navigate(u);
        }
        private void Online2(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://drive.google.com/open?id=1T930nr50si31_GpZk85EfNv1nNMC-nmH");
            w3.Navigate(u);
        }

        private void Lectures(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://drive.google.com/open?id=1zlC_RcemLQBYylgSj7ZcJyDpoLNeTruO");
            w3.Navigate(u);
        }

        private void Notes(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://drive.google.com/open?id=1nyNPyyErFg4RvZW-glCSJPWVZV88SPma");
            w3.Navigate(u);
        }

        private void Ebook(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://drive.google.com/open?id=1_N5V6veMUZjPVTM077rXS_2oyalPAjRH");
            w3.Navigate(u);
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var cv = SystemNavigationManager.GetForCurrentView();
            cv.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            cv.BackRequested += backButton_Tapped;
        }
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            var cv = SystemNavigationManager.GetForCurrentView();
            cv.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            cv.BackRequested -= backButton_Tapped;
        }
        private void backButton_Tapped(object sender, BackRequestedEventArgs e)
        {
            if (Frame.CanGoBack) Frame.GoBack();
        }

        private void Tut(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.tutorialspoint.com/data_communication_computer_network/");
            w3.Navigate(u);
        }
    }
}
