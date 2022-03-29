using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appssss.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            MessagingCenter.Send<object, int>(this, "Add", 1);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}