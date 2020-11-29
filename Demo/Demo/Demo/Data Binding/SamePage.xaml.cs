using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Demo.Models;
using System.Collections.ObjectModel;

namespace Demo.Data_Binding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SamePage : ContentPage
    {
        ObservableCollection<ListElementModel> _list;
        public SamePage()
        {
            InitializeComponent();
            _list = new ObservableCollection<ListElementModel>();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            elementList2.ItemsSource = _list;
        }

        private void saveBt_Clicked(object sender, EventArgs e)
        {
            string name = addInList.Text;
            if (name != null)
            {
                _list.Add(new ListElementModel { ID = 1, Name = name, Checked = checkedswich.IsToggled });
                checkedswich.IsToggled = false;
                addInList.Text = "";
                
            }
        }

        private void elementList2_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var edit = e.SelectedItem as ListElementModel;
            addInList.Text = edit.Name;
            checkedswich.IsToggled = edit.Checked;
            try
            {
                foreach (ListElementModel id in _list)
                {
                    if (id.Name.Equals(edit.Name) == true)
                    {
                        _list.Remove(id);
                    }
                }
            }
            catch (InvalidOperationException es)
            {

            }
        }
    }
}