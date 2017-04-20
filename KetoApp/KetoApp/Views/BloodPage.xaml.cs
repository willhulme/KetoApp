using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KetoApp.Pages
{
    public partial class BloodPage : ContentPage
    {
        private bool KetoFlag;
        private bool StartFlag;
        public BloodPage(bool ketones, bool start)
        {
            InitializeComponent();
            BindingContext = new ViewModels.Entries();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
            KetoFlag = ketones;
            StartFlag = start;
        }

        public async void NextTapped(object sender, EventArgs args)
        {
            var mmol = mmolString.Text;
            Decimal mmolDec = Convert.ToDecimal(mmol);
            if (mmolDec >= 12 & StartFlag)
            {
                KetoFlag = false;
                StartFlag = false;
                await Navigation.PushAsync(new HighBloodPage());
            }
            else if (mmolDec < 12 & !KetoFlag)
            {
                KetoFlag = false;
                await Navigation.PushAsync(new NovorapidLow());
            }
            else if (mmolDec < 12 & KetoFlag)
            {
                KetoFlag = false;
                await Navigation.PushAsync(new StarvePage());
            }
            else if(mmolDec >= 12 & KetoFlag)
            {
                KetoFlag = false;
                await Navigation.PushAsync(new NovorapidHigh());
            }
            else if (mmolDec >= 12 & !KetoFlag)
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
