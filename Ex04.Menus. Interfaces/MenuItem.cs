using System.Collections.Generic;
using System.ComponentModel;
using Console = System.Console;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        public bool IsMainMenu { get; }
        public List<MenuItem> SubItems { get; }
        public string Title { get; }

        public MenuItem(string i_Title, bool i_IsMainMenu = false)
        {
            Title = i_Title;
            IsMainMenu = i_IsMainMenu;
            SubItems = new List<MenuItem>();
        }
        public void Show()
        {
            bool back = false;

            while (!back)
            {
                showCurrentMenu();
                int inputFromUser = getInputFromUser();
                Console.Clear();

                if(inputFromUser == 0)
                {
                    back = true;
                }
                else if (SubItems[inputFromUser-1] is IActionable actionable)
                {
                    actionable.Action();
                }
                else
                {
                    SubItems[inputFromUser-1].Show();
                }
            }
        }

        private int getInputFromUser()
        {
            int result;

            Console.WriteLine($"Enter your request: (1 to 2 or press '0' to {(IsMainMenu ? "exit" : "back")}).");
            while (!int.TryParse(Console.ReadLine(), out result) || result > 2 || result < 0)
            {
                Console.WriteLine("Invalid input");
            }
            ;
            return result;
        }

        private void showCurrentMenu()
        {
            int index = 1;

            Console.WriteLine($@"
**{Title}**
------------------------");
            foreach(MenuItem subMenuItem in SubItems)
            {
                Console.WriteLine($"{index++} -> {subMenuItem.Title}");
            }
            Console.WriteLine($@"0 -> {(IsMainMenu ? "Exit" : "Back")}
------------------------");
        }
    }
}
