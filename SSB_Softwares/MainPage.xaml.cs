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



//The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SSB_Softwares
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
          /*   CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
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
            Uri u = new Uri("http://courseweb.sliit.lk/");
            w1.Navigate(u);   
           
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
        private void backButton_Tapped(object sender, BackRequestedEventArgs e )
        {
            if (Frame.CanGoBack) Frame.GoBack();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("http://courseweb.sliit.lk/");
            w1.Navigate(u);
            U1.Width = 0;
            U1.Height = 0;
            B1.Width = 0;
            B1.Height = 0;
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("http://www.sliit.lk/student/");
            w1.Navigate(u);
            U1.Width = 0;
            U1.Height = 0;
            B1.Width = 0;
            B1.Height = 0;
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Modules));
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            
            Uri u = new Uri("https://chat.whatsapp.com/BpVVkboxn5xA09qEJMKKp1");
            w1.Navigate(u);
            U1.Width = 0;
            U1.Height = 0;
            B1.Width = 0;
            B1.Height = 0;
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            CoreApplication.Exit();
        }

        private void B5_Click(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://mail.google.com/mail/u/0/#inbox");
            w1.Navigate(u);
            U1.Width = 0;
            U1.Height = 0;
            B1.Width = 0;
            B1.Height = 0;
        }

        private void Google(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.google.lk/?gfe_rd=cr&dcr=0&ei=s-BBWuK1NJerrAHRpa_YDw");
            w1.Navigate(u);
            U1.Width = 0;
            U1.Height = 0;
            B1.Width = 0;
            B1.Height = 0;
        }

        private void Entertain(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Entertainment));
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

        private void Menu2(object sender, RoutedEventArgs e)
        {
            menu2.IsPaneOpen = true;
        }

        private void Mouse_on2(object sender, PointerRoutedEventArgs e)
        {
            menu2.IsPaneOpen = true;
        }

        private void Mouse_off2(object sender, PointerRoutedEventArgs e)
        {
            menu2.IsPaneOpen = false;
        }

        private void Pariganaka(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://www.magzter.com/LK/Wijeya_Newspapers_Ltd./Pariganaka/Technology/");
            w1.Navigate(u);
            U1.Width =263;
            U1.Height = 30;
            B1.Width = 263;
            B1.Height = 30;
        }

        private void Git(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://github.com/");
            w1.Navigate(u);
            U1.Width = 0;
            U1.Height = 0;
            B1.Width = 0;
            B1.Height = 0;
        }

        private void Drive(object sender, RoutedEventArgs e)
        {
            Uri u = new Uri("https://drive.google.com/drive/");
            w1.Navigate(u);
            U1.Width = 0;
            U1.Height = 0;
            B1.Width = 0;
            B1.Height = 0;
        }
    }
}
