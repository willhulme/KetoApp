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
    public class Entries : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public Models.TaskModel Model { get; set;}
        public Entries()
        {
            Model = new Models.TaskModel()
            {
                mmolString = "0.00"
            };
        }
        public Command mmolEntryCommand {
            get {
                return new Command(() =>
                {
                    Model.mmolString = Model.mmolString;
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
