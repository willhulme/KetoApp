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
        }

        public async void UnwellTapped (object sender, EventArgs args)
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
            //await Navigation.PushAsync(new SQLite.SQLiteAboutPage().GetAboutPage());
        }

        public async void HelpTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new HelpPage());
        }
    }
}
