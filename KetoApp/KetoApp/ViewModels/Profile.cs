using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KetoApp.ViewModels
{
    public class Profile : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Models.AboutModel Model { get; set; }
        public Profile()
        {
            Model = new Models.AboutModel()
            {
                DOB = new DateTime(1995, 02, 03),
                Pump = false,
                TDD = 50,
                Num1 = "01382 632293",
                Num2 = "01382 633909"
            };
        }
        public Command getProfile
        {
            get
            {
                return new Command(() =>
                {
                    Model.DOB = Model.DOB;
                    Model.Pump = Model.Pump;
                    Model.TDD = Model.TDD;
                    Model.Num1 = Model.Num1;
                    Model.Num2 = Model.Num2;
                    OnPropertyChanged();
                });
            }
        }
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
