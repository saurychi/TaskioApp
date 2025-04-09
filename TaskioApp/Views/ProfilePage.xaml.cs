namespace TaskioApp.Views;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
	}

    private async void ToBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void ToChangeClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ChangeProfilePage());
    }

    private async void ToLoginClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}