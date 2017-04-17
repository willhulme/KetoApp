using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Switchboard.ViewModels
{
    public class Entries : INotifyPropertyChanged
    {
        private string _mmolString;
        public string mmolString
        {
            get
            {
                return _mmolString;
            }
            set
            {
                _mmolString = value;
                OnPropertyChanged();
            }
        }

        public Command mmolEntryCommand {
            get {
                return new Command(() =>
                {
                    mmolString = mmolString;
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
