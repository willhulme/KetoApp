using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KetoApp.Pages
{
    public partial class ExtraDosePage : ContentPage
    {
        public ExtraDosePage()
        {
            InitializeComponent();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
        }
        public async void OKTapped(object sender, EventArgs args)
        {
            await Navigation.PopToRootAsync();
        }
        public async void RemindTapped(object sender, EventArgs args)
        {
            //Dependency Service goes here
            //await Navigation.PopToRootAsync();
        }
        public async void WorseTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new HelpPage());
        }
    }
}
