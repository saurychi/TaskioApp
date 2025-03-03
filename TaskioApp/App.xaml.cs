using Microsoft.Maui.Controls;

namespace TaskioApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell(); // Ensure AppShell is the main page
        }
    }
}
