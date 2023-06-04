using System;

namespace Ex04.Menus.Interfaces
{
    public class Version : MenuItem, IActionable
    {
        public Version() : base("Show version")
        {
        }

        public void Action()
        {
            Console.WriteLine("Version: 23.2.4.9805");
        }
    }
}
