using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace KetoApp
{
    public partial class IconButton : ContentView
    {
        public IconButton()
        {
            InitializeComponent();
        }

        public ImageSource Icon
        {
            get { return MainIcon.Source; }
            set { MainIcon.Source = value; }
        }

        public string Label
        {
            get { return MainLabel.Text; }
            set { MainLabel.Text = value; }
        }
    }
}
