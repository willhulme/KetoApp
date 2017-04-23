using KetoApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KetoApp
{
    public partial class MainPage : ContentPage
    {
        private bool ketones;
        private bool start;
        public MainPage()
        {
            InitializeComponent();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
            BindingContext = new ViewModels.Profile();
        }
        public async void UnwellTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new UnwellPage());
        }
        public async void BloodTapped(object sender, EventArgs args)
        {
            ketones = false;
            start = true;
            await Navigation.PushAsync(new BloodPage(ketones, start));
        }
        public async void AboutTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AboutPage());
        }
        public async void FoodTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new FoodPage());
        }
        public async void TeethTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new TeethPage());
        }
        public async void KetoTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new CreditsPage());
        }
    }
}
