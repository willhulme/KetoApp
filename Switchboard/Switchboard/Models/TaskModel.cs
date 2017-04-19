using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Switchboard.Models
{
    public class TaskModel
    {
        private string _mmolString { get; set; }
        public string mmolString
        {
            get
            {
                return _mmolString;
            }
            set
            {
                _mmolString = value;
            }
        }

    }
}
