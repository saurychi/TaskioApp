using Microsoft.Maui.Controls;
using TaskioApp.Views;

namespace TaskioApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Ensure the first page is the LoginPage
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));

            // Set the initial page
            CurrentItem = Items.FirstOrDefault(x => x.Route == "LoginPage");
        }
    }
}
