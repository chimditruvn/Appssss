using Appssss.Services;
using Appssss.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appssss
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            App.Current.MainPage = new NavigationPage(new Mainview(0));
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
