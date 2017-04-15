using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Switchboard.Pages
{
    public partial class AboutPage : CarouselPage
    {
        public AboutPage()
        {
            InitializeComponent();
            this.Title = "KetoApp";
            this.BackgroundColor = Color.White;
        }
        public async void NewTapped(object sender, EventArgs args)
        {
            this.Children.Add(new ProfilePage());
        }
    }
}
