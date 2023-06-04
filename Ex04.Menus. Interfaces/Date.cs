using System;

namespace Ex04.Menus.Interfaces
{
    public class Date : MenuItem, IActionable
    {
        public Date() : base("Show date")
        {
        }

        public void Action()
        {
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
        }
    }
}
