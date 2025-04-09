namespace TaskioApp.Views;

public partial class SignupPage : ContentPage
{
	public SignupPage()
	{
        InitializeComponent();
	}

    private async void OnStartClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}