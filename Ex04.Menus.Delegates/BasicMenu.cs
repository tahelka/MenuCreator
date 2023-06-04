using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class BasicMenu
    {
        private const int ExitOrBack = 0;
        private readonly bool r_IsMainMenu;
        private List<MenuItem> m_SubItems;

        public string MenuTitle { get; set; }

        public BasicMenu(string i_MenuTitle, bool i_IsMainMenu)
        {
            MenuTitle = i_MenuTitle;
            r_IsMainMenu = i_IsMainMenu;
            m_SubItems = new List<MenuItem>();
        }

        internal void AddSubMenuItemToMenu(MenuItem i_MenuItemToAdd)
        {
            m_SubItems.Add(i_MenuItemToAdd);
        }

        private void showCurrentMenu()
        {
            int index = 1;

            Console.WriteLine($@"
**{MenuTitle}**
------------------------");
            foreach (MenuItem menuItem in m_SubItems)
            {
                Console.WriteLine($"{index++} -> {menuItem.m_BasicMenu.MenuTitle}");
            }
            Console.WriteLine($@"0 -> {(r_IsMainMenu ? "Exit" : "Back")}
------------------------");
        }

        internal bool IsSubMenu()
        {
            bool isSubMenu;

            if (m_SubItems.Count == 0)
            {
                isSubMenu = false;
            }
            else
            {
                isSubMenu = true;
            }

            return isSubMenu;
        }

        public void RunMenu()
        {
            showCurrentMenu();
            int userChoice = getInputFromUser();
            if (userChoice == ExitOrBack)
            {
                return;
            }

            MenuItem nextMenuItem = m_SubItems[userChoice - 1];
            if (nextMenuItem.m_BasicMenu.IsSubMenu())
            {
                nextMenuItem.m_BasicMenu.RunMenu();
            }
            else
            {
                nextMenuItem.MenuItemSelected();
            }

            RunMenu();
        }

        private int getInputFromUser()
        {
            int result;
            int numberOfMenuItems = m_SubItems.Count;

            Console.WriteLine($"Enter your request: (1 to {numberOfMenuItems} or press '0' to {(r_IsMainMenu ? "exit" : "back")}).");
            while (!int.TryParse(Console.ReadLine(), out result) || result > numberOfMenuItems || result < 0)
            {
                Console.WriteLine("Invalid input");
            }

            return result;
        }
    }  
}