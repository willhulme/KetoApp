using Switchboard.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Switchboard
{
    public partial class MainSwitchboard : ContentPage
    {
        public MainSwitchboard()
        {
            InitializeComponent();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
        }

        public async void UnwellTapped (object sender, EventArgs args)
        {
            await Navigation.PushAsync(new UnwellPage());
        }

        public async void BloodTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new BloodPage());
        }

        public async void AboutTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AboutPage());
        }

        public async void HelpTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new HelpPage());
        }
    }
}
