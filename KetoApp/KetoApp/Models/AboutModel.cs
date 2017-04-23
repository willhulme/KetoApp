using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetoApp.Models
{
    public class AboutModel
    {
        private DateTime _DOB { get; set; }
        private bool _Pump { get; set; }
        private int _TDD { get; set; }
        private string _Num1 { get; set; }
        private string _Num2 { get; set; }
        public DateTime DOB { get { return _DOB; } set { _DOB = value;  } }
        public bool Pump { get { return _Pump; } set { _Pump = value; } }
        public int TDD { get { return _TDD; } set { _TDD = value; } }
        public string Num1 { get { return _Num1; } set { _Num1 = value; } }
        public string Num2 { get { return _Num2; } set { _Num2 = value; } }
    }
}
