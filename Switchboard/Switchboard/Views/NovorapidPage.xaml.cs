using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Switchboard.Pages
{
    public partial class NovoRapidPage : ContentPage
    {
        public NovoRapidPage()
        {
            InitializeComponent();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
        }

        public async void YesTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MainSwitchboard());
        }
        public async void NoTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MainSwitchboard());
        }
    }
}
