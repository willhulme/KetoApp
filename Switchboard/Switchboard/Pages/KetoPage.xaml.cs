using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Switchboard.Pages
{
    public partial class KetoPage : ContentPage
    {
        public KetoPage()
        {
            InitializeComponent();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
        }
        public async void EmergencyTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new HelpPage());
        }
    }
}
