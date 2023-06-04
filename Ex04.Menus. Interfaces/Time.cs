using System;

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
