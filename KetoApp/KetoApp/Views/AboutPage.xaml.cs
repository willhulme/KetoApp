using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

using Xamarin.Forms;

namespace KetoApp.Pages
{
    public partial class AboutPage : ContentPage
    {
        protected override void OnAppearing()
        {
            DOB.Date = new DateTime(1995, 02, 03);
            Pump.IsToggled = false;
            TDD.Text = "50";
            Num1.Text = "01382 632293";
            Num2.Text = "01382 633909";
        }
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.Profile();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
        }
        private void Pump_Toggled(object sender, ToggledEventArgs e)
        {

        }
    }
}
