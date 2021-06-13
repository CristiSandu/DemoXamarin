using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Demo.API
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class APIExp : ContentPage
    {
        public APIExp()
        {
            InitializeComponent();

        }


        public async void turnOnOffFlashLight()
        {
            try
            {
                if (enableFlash.IsToggled == true)
                {
                    await Flashlight.TurnOnAsync();
                }
                else
                {
                    await Flashlight.TurnOffAsync();
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void enableFlash_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            turnOnOffFlashLight();
        }

        private async void getLocation_Clicked(object sender, EventArgs e)
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                if (location == null)
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest
                    {
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(30)
                    }) ;
                }

                if (location == null)
                {
                    locationLabel.Text = "No GPS";
                }else
                {
                    locationLabel.Text = $"{location.Latitude} -- {location.Longitude}";
                }
            }catch(Exception ex)
            {
             
            }
        }
    }
}