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
        private bool ketones;
        private bool start;
        public KetoPage()
        {
            InitializeComponent();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
        }
        public async void YesTapped(object sender, EventArgs args)
        {
            ketones = true;
            start = false;
            await Navigation.PushAsync(new BloodPage(ketones, start));
        }
        public async void NoTapped(object sender, EventArgs args)
        {
            ketones = false;
            start = false;
            await Navigation.PushAsync(new BloodPage(ketones, start));
        }
    }
}
