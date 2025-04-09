namespace TaskioApp.Views;

public partial class ChangeProfilePage : ContentPage
{
	public ChangeProfilePage()
	{
		InitializeComponent();
	}

    private async void ToBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void ToLoginClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }

}