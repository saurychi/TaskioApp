﻿namespace TaskioApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

             MainPage = new AppShell();

            // MainPage = new Views.WelcomePage();

        }
    }
}
