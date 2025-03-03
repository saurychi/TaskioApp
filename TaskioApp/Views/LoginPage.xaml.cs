using Microsoft.Maui.Controls;

namespace TaskioApp.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Login", "Login button clicked!", "OK");
        }
    }
}

