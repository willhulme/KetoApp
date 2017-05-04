using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KetoApp.Pages
{
    public partial class KetoPage : ContentPage
    {
        private bool ketones;
        public KetoPage()
        {
            InitializeComponent();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
        }
        public async void YesTapped(object sender, EventArgs args)
        {
            ketones = true;
            await Navigation.PushAsync(new BloodPage(ketones));
        }
        public async void NoTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new CheckPage());
        }
    }
}
