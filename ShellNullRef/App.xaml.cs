using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ShellNullRef.Services;
using ShellNullRef.Views;

namespace ShellNullRef
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new ContentPage()
            //{ 
            //    Content = new Label { Text="Hi" },
            //};
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
