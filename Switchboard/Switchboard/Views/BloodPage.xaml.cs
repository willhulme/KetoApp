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
        public BloodPage()
        {
            InitializeComponent();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
            BindingContext = new ViewModels.Entries();
        }

        public async void NextTapped(object sender, EventArgs args)
        {
            Decimal mmolDec = 13;
            if (mmolDec < 12)
            {
                await Navigation.PushAsync(new StarvePage());
            }
            else if (mmolDec >= 12)
            {
                await Navigation.PushAsync(new ExtraDosePage());
            }
        }
    }
}
