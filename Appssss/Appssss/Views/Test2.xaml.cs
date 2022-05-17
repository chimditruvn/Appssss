using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appssss.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Test2 : ContentPage
    {
        public Test2()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var statusbar = DependencyService.Get<IStatusBarPlatformSpecific>();
            statusbar.SetStatusBarColor(Color.FromHex("f1f1f1"));
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            var statusbar = DependencyService.Get<IStatusBarPlatformSpecific>();
            statusbar.SetStatusBarColor(Color.FromHex("f1f1f1"));
        }
    }
}