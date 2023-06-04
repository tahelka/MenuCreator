using System;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        public MenuItem Menu { get; }

        public MainMenu(string i_Title)
        {
            Menu = new MenuItem(i_Title, true);
        }

        public void Show()
        {
            Menu.Show();
            Console.Clear();
        }
    }
}
