using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KetoApp.Pages
{
    public partial class HighBloodPage : ContentPage
    {
        public HighBloodPage()
        {
            InitializeComponent();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
        }

        public async void YesTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new KetoPage());
        }
        public async void NoTapped(object sender, EventArgs args)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
