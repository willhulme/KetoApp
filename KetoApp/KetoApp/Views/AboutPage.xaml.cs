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
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.Profile();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
        }
        public async void NextTapped(object sender, EventArgs args)
        {
            string Name = xName.Text;
            DateTime DOB = xDOB.Date;
            bool Pump = Convert.ToBoolean(xPump.IsToggled);
            int TDD = Convert.ToInt32(xTDD.Text);
            string Num1 = xNum1.Text;
            string Num2 = xNum2.Text;
            await Navigation.PopToRootAsync();
        }
    }
}
