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
                await Navigation.PushAsync(new UnwellPage());
            }
            if (mmolDec < 12 & KetoFlag)
            {
                KetoFlag = false;
                await Navigation.PushAsync(new StarvePage());
            }
            if (mmolDec >= 12  & KetoFlag)
            {
                KetoFlag = false;
                await Navigation.PushAsync(new ExtraDosePage());
            }
            if (mmolDec >= 17 & !KetoFlag)
            {
                KetoFlag = false;
                await Navigation.PushAsync(new HighBloodPage());
            }
        }
    }
}
