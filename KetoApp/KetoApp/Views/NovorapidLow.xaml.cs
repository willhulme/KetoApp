﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KetoApp.Pages
{
    public partial class NovorapidLow : ContentPage
    {
        public NovorapidLow()
        {
            InitializeComponent();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
        }
        public async void OKTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new CheckPage());
        }
    }
}
