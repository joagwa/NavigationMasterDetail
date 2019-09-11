using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MasterDetailNavigation.Services;
using MasterDetailNavigation.Views;

namespace MasterDetailNavigation
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            DependencyService.Register<NavigationService>();
            DependencyService.Register<MockDataStore>();
            MainPage = new MainView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
