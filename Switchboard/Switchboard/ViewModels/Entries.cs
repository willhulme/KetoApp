using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchboard.ViewModels
{
    public class Entries
    {
        public Models.TaskModel TaskModel { get; set; }
        
        public Entries()
        {
            TaskModel = new Models.TaskModel
            {
                mmol = 10
            };
        }
    }
}
