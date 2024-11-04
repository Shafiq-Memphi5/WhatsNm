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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WhatsNm
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateAccount : Page
    {
        public async void Popup()
        {
            var mes = new ContentDialog()
            {
                Title = "Sign Up",
                Content = "Account created successfully! You can log in.",
                CloseButtonText = "OK"
            };
            await mes.ShowAsync();
        }
        public async void Popups(string message)
        {
            var mes = new ContentDialog()
            {
                Title = "Error",
                Content = message,
                CloseButtonText = "OK"
            };
            await mes.ShowAsync();
        }
        public CreateAccount()
        {
            this.InitializeComponent();
        }

        private void login_Btn(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void signup_Btn(object sender, RoutedEventArgs e)
        {
            if(txtEmail.Text == "" || txtName.Text == "" || txtPhn.Text == "" || txtpw.Text == "")
            {
                Popups("Missing Information");
            }
            else
            {
                Popup();
            }
        }
    }
}
