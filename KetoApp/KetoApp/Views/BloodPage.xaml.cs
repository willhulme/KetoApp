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
        public BloodPage(bool ketones)
        {
            InitializeComponent();
            BindingContext = new ViewModels.Entries();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
            KetoFlag = ketones;
        }

        public async void NextTapped(object sender, EventArgs args)
        {
            if (!string.IsNullOrWhiteSpace(mmolString.Text))
            {
                Decimal mmol = Convert.ToDecimal(mmolString.Text);
                if (mmol < 12 & !KetoFlag)
                {
                    KetoFlag = false;
                    await Navigation.PushAsync(new HypoPage());
                }
                else if (mmol < 12 & KetoFlag)
                {
                    KetoFlag = false;
                    await Navigation.PushAsync(new StarvePage());
                }
                else if (mmol >= 12 & KetoFlag)
                {
                    KetoFlag = false;
                    await Navigation.PushAsync(new ExtraDosePage());
                }
                else if (mmol >= 12 & !KetoFlag)
                {
                    KetoFlag = false;
                    await Navigation.PushAsync(new HighBloodPage());
                }
            }
            else
            {
                await Navigation.PopToRootAsync();
            }
        }
    }
}
