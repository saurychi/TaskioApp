namespace TaskioApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnStartClicked(object sender, EventArgs e)
        {
            // Navigate to MainPage (or another page)
            await Navigation.PushAsync(new SignupPage());
        }
    }

}
