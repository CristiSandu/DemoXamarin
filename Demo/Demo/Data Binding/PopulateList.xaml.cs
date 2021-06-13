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
    public partial class PopulateList : ContentPage
    {
        List<ListElementModel> _list = null;
        public PopulateList()
        {
            InitializeComponent();
            
        }
        public PopulateList(List<ListElementModel> list)
        {
            InitializeComponent();
            _list = list;
        }

        private async void save_Clicked(object sender, EventArgs e)
        {
            if (_list != null)
            {
                string name = placeHolderName.Text;
                bool select = isSelected.IsToggled;
                ListElementModel elem = new ListElementModel { ID = 1, Name = name, Checked = select };
                _list.Add(elem);
                await Navigation.PushAsync(new ListElements(_list));
            }else
            {
                await Navigation.PopAsync();
            }

        }

        private async void cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

        }
    }
}