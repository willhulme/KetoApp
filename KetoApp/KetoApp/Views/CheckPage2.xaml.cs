﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KetoApp.Pages
{
    public partial class CheckPage2 : ContentPage
    {
        public CheckPage2()
        {
            InitializeComponent();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
        }
        public async void OKTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new StockPage());
        }
        public async void WorseTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new HelpPage());
        }
    }
}
