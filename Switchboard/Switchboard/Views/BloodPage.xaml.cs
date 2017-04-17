using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Switchboard.Pages
{
    public partial class BloodPage : ContentPage
    {
        private bool KetoFlag = false;
        public BloodPage(bool ketones)
        {
            InitializeComponent();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
            KetoFlag = ketones;
        }

        public async void NextTapped(object sender, EventArgs args)
        {
            var mmol = mmolString.Text;
            Decimal mmolDec = Convert.ToDecimal(mmol);
            if (mmolDec < 12 & !KetoFlag)
            {
                KetoFlag = false;
                await Navigation.PushAsync(new HypoPage());
            }
            if (mmolDec < 12 & KetoFlag)
            {
                KetoFlag = false;
                await Navigation.PushAsync(new StarvePage());
            }
            if (mmolDec >= 12 & KetoFlag)
            {
                KetoFlag = false;
                await Navigation.PushAsync(new ExtraDosePage());
            }
            if (mmolDec >= 12 & !KetoFlag)
            {
                KetoFlag = false;
                await Navigation.PushAsync(new NovoRapidPage());
            }
            if (mmolDec >= 17 & !KetoFlag)
            {
                KetoFlag = false;
                await Navigation.PushAsync(new HighBloodPage());
            }
        }
        public async void HypoTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new HypoPage());
        }
        public async void FoodTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new FoodPage());
        }
        public async void TeethTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new TeethPage());
        }
    }
}
