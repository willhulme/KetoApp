using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KetoApp.Pages
{
    public partial class CheckPage : ContentPage
    {
        public CheckPage()
        {
            InitializeComponent();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
        }

        public async void OKTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new StockPage());
        }
        public async void RemindTapped(object sender, EventArgs args)
        {
            //Dependency Service goes here
            //await Navigation.PopToRootAsync();
        }
    }
}
