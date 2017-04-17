using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Switchboard.Pages
{
    public partial class TeethPage : ContentPage
    {
        public TeethPage()
        {
            InitializeComponent();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
        }
        
        public async void OKTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new MainSwitchboard());
        }
    }
}
