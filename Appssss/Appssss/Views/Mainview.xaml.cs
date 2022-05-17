using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace Appssss.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mainview : Xamarin.Forms.TabbedPage
    {
        public Mainview(int index)
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            SetPage(index);
            
        }
        void SetPage(int index)
        {
            CurrentPage = Children[index];
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}