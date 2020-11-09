using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Demo.Models;

namespace Demo.Data_Binding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListElements : ContentPage
    {
        List<ListElementModel> _list = new List<ListElementModel>();
        public ListElements()
        {
            InitializeComponent();
        }

        public ListElements(List<ListElementModel> list)
        {
            InitializeComponent();
            _list = list;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListOfNames.ItemsSource = _list;
        }

        private async void addToList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PopulateList(_list));
        }

        private async void ListOfNames_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new PopulateList
                {
                    BindingContext = e.SelectedItem as ListElementModel
                });
            }
        }
    }
}