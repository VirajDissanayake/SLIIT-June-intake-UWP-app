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
using Windows.Storage;
using Windows.Data.Pdf;
using System.Net.Http;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage.Streams;
using System.Collections.ObjectModel;
using Windows.UI.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SSB_Softwares
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class tutorials : Page
    {
        public tutorials()
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
        private void T1(object sender, RoutedEventArgs e)
        {
            I1.Height = 0;
            I1.Width = 0;
            Uri u = new Uri("https://www.youtube.com/watch?v=1nEluKUOic8");
            w2.Navigate(u);
        }

        private void Validation(object sender, RoutedEventArgs e)
        {
            I1.Height = 0;
            I1.Width = 0;
            Uri u = new Uri("https://www.youtube.com/watch?v=R0Xa3WJf7T8");
            w2.Navigate(u);
        }

        private void Why(object sender, RoutedEventArgs e)
        {
            I1.Height = 0;
            I1.Width = 0;
            Uri u = new Uri("https://www.youtube.com/watch?v=Y0k7RGWMpvo");
            w2.Navigate(u);
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

        private void Ireport(object sender, RoutedEventArgs e)
        {
            I1.Height = 0;
            I1.Width = 0;
            Uri u = new Uri("https://www.youtube.com/watch?v=Fw_1hlRGgLo&t=617s");
            w2.Navigate(u);
        }

        private void Exe(object sender, RoutedEventArgs e)
        {
            I1.Height = 0;
            I1.Width = 0;
            Uri u = new Uri("https://www.youtube.com/watch?v=mm_-mnDKAjo");
            w2.Navigate(u);
        }

        private void Csharp(object sender, RoutedEventArgs e)
        {
            I1.Height = 0;
            I1.Width = 0;
            Uri u = new Uri("https://www.youtube.com/watch?v=Y0k7RGWMpvo");
            w2.Navigate(u);
        }

        private void Pass(object sender, RoutedEventArgs e)
        {
            I1.Height = 0;
            I1.Width = 0;
            Uri u = new Uri("https://www.youtube.com/watch?v=oFsk8mcWfOY");
            w2.Navigate(u);
        }

        private void Web(object sender, RoutedEventArgs e)
        {
            I1.Height = 0;
            I1.Width = 0;
            Uri u = new Uri("https://www.youtube.com/watch?v=SZLZ9ESYGyY");
            w2.Navigate(u);
        }

        private void Jar(object sender, RoutedEventArgs e)
        {
            I1.Height = 0;
            I1.Width = 0;
            Uri u = new Uri("https://www.youtube.com/watch?v=bE6YvJndboo");
            w2.Navigate(u);
        }

        private void Splash(object sender, RoutedEventArgs e)
        {
            I1.Height = 0;
            I1.Width = 0;
            Uri u = new Uri("https://www.youtube.com/watch?v=M3AemVNwr3o");
            w2.Navigate(u);
        }

        private void Pro(object sender, RoutedEventArgs e)
        {
            I1.Height = 0;
            I1.Width = 0;
            Uri u = new Uri("http://www.axia-consulting.co.uk/html/it_project_proposal.html");
            w2.Navigate(u);
        }

        private void Tmp(object sender, RoutedEventArgs e)
        {
            I1.Height = 0;
            I1.Width = 0;
            Uri u = new Uri("https://www.pandadoc.com/software-development-proposal-template/");
            w2.Navigate(u);
        }

    }
    }

