using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class Time : MenuItem, IActionable
    {
        public Time() : base("Show time")
        {
        }

        public void Action()
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
