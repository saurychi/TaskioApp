namespace TaskioApp.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnStartClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddTaskPage());
        }
        
        private async void OnProfileClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }

        private async void OnItemTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TaskItemPage());
        }
    }

}
