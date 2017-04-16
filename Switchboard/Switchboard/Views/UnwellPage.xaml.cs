using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Switchboard.Pages
{
    public partial class UnwellPage : ContentPage
    {
        public UnwellPage()
        {
            InitializeComponent();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
        }
        public async void KetonesTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new KetoPage());
        }
    }
}
