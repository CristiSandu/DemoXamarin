﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Demo.Data_Binding;

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
    }
}