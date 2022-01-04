using Appssss.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Appssss.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}