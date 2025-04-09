namespace TaskioApp.Views;

public partial class TaskItemPage : ContentPage
{
	public TaskItemPage()
	{
		InitializeComponent();
	}

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}