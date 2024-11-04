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
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WhatsNm
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public async void Popup()
        {
            var mes = new ContentDialog
            {
                Title = "Login Error",
                CloseButtonText = "OK",
                Content = "Invalid phone number or password. Please try again"
            };
            await mes.ShowAsync();
        }
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void signup_Btn(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(CreateAccount));
        }

        private void forgot_Btn(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(ForgotPassword));
        }

        private void login_Btn(object sender, RoutedEventArgs e)
        {
            if (phnNum.Text == "0701909645" && pw1.Text == "123")
            {
                Frame.Navigate(typeof(HomePage));
            }
            else
            {
                Popup();
            }
        }
    }
}
