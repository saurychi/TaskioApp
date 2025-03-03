using Microsoft.Maui.Controls;

namespace TaskioApp
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void OnStartClicked(object sender, EventArgs e)
        {
            // Navigate to MainPage (or another page)
            await Navigation.PushAsync(new MainPage());
        }
    }
}
