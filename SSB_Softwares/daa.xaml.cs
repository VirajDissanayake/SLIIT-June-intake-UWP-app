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
    public sealed partial class daa : Page
    {
        public daa()
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
        private void Home(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Modules(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Modules));
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            CoreApplication.Exit();
        }

        private void Online(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://drive.google.com/open?id=1qAej0vtd4gdTpl-S4I6-LcJynk8lfvN_");
            w3.Navigate(u);
        }

        private void Lectures(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://drive.google.com/open?id=1wIeBGRget6DnP26jaYYiEdSiicsFR7Mj");
            w3.Navigate(u);
        }

        private void Notes(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://drive.google.com/open?id=10qdn9Jk7V9t3RjicuJlcdUAyzGklOV5w");
            w3.Navigate(u);
        }

        private void Greedy(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.youtube.com/watch?v=A8CEvPmNpKQ");
            w3.Navigate(u);
        }

        private void Tut(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.tutorialspoint.com/design_and_analysis_of_algorithms/design_and_analysis_of_algorithms_introduction.htm");
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
    }
}
