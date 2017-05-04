using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KetoApp.Pages
{
    public partial class HelpPage : ContentPage
    {
        protected override void OnAppearing()
        {
            Num1.Text = "01382 632293";
            Num2.Text = "01382 633909";
        }
        public HelpPage()
        {
            InitializeComponent();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
        }
        public async void BackTapped(object sender, EventArgs args)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
