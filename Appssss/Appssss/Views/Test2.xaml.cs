using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Appssss.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Test2 : ContentPage
    {
        private List<Monkey> _listProd;
        private const string monkeyUrl = "https://montemagno.com/monkeys.json";
        private readonly HttpClient httpClient = new HttpClient();

        public ObservableCollection<Monkey> Monkeys { get; set; } = new ObservableCollection<Monkey>();
        public Test2()
        {
            InitializeComponent();
            LoadData();

        }
        protected async void LoadData()
        {
            var monkeyJson = await httpClient.GetStringAsync(monkeyUrl);
            var monkeys = JsonConvert.DeserializeObject<Monkey[]>(monkeyJson);


            foreach (var monkey in monkeys)
            {
                Monkeys.Add(monkey);
            }

            _listProd = Monkeys.ToList();

            _data.ItemsSource = _listProd;

            Device.StartTimer(TimeSpan.FromSeconds(4), (Func<bool>)(() =>
            {
                _data.ScrollTo(_listProd.Count + 2, -1, ScrollToPosition.Start, true);
                return false;
            }));
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();

        }

        private void _data_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            //loop the item when reaching the last element
            
        }
    }
}