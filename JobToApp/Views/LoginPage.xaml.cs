using JobToApp.Services;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JobToApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void GoRegister(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        private async void DoLogin(object sender, EventArgs e)
        {
            var service = new UserService();
            bool login = await service.LoginAsync(txtUsername.Text, txtPassword.Text);
            if (login)
            {
                App.Current.MainPage = new NavigationPage(new MainPage());
            }
            else
            {
                await DisplayAlert("Erro", "Dados incorretos", "Tente novamente");
            }
        }
    }
}