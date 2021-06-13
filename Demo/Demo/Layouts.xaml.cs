using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Demo.Data_Binding;
using Demo.API;


namespace Demo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Layouts : ContentPage
    {
        public Layouts()
        {
            InitializeComponent();
        }

        private async void testNavigation_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListElements());
        }

        private async void goToAddInList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SamePage());
        }

        private async void goToINotifyEx_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SamleBataBinding());
        }

        private async void APIExp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new APIExp());
        }
    }
}