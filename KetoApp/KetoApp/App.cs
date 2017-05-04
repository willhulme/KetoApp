using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace KetoApp
{
    public class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(new MainPage());
        }
        protected override void OnStart()
        {
            MainPage = new NavigationPage(new MainPage());
        }
        protected override void OnSleep()
        {
            MainPage = new NavigationPage(new MainPage());
        }
        protected override void OnResume()
        {
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
