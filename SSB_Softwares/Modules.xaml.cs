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
    public sealed partial class Modules : Page
    {
        public Modules()
        {
            this.InitializeComponent();
          /*  CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            var view = ApplicationView.GetForCurrentView();
            var titleBar = view.TitleBar;

            titleBar.BackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ForegroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.InactiveBackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.InactiveForegroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ButtonBackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ButtonHoverBackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ButtonPressedBackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ButtonInactiveBackgroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ButtonForegroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ButtonHoverForegroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ButtonPressedForegroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);
            titleBar.ButtonInactiveForegroundColor = Windows.UI.Color.FromArgb(0, 0, 0, 0);*/

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

        private void Dccn2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(dccn2));
            ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            CoreApplication.Exit();
        }

        private void Spd(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(spd));
            ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
        }

        private void Daa(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(daa));
            ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
        }

        private void Se2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(se2));
            ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
        }

        private void Itpa(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(itpa));
            ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
            ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
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
