using System;
using MenuDelegates = Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    class TestMenuUsingDelegate
    {
        private MenuDelegates.MainMenu m_MainMenu;

        public void CreateAndRunMenu()
        {
            createMainMenu();
            m_MainMenu.RunMenu();
        }

        private void createMainMenu()
        {
            m_MainMenu = new MenuDelegates.MainMenu("Delegate Main Menu");
            MenuDelegates.MenuItem showDateTimeMenu = createShowDateTimeMenu();
            MenuDelegates.MenuItem versionAndSpacesMenu = createVersionAndSpacesMenu();
            m_MainMenu.AddSubMenuItemToMainMenu(showDateTimeMenu);
            m_MainMenu.AddSubMenuItemToMainMenu(versionAndSpacesMenu);
        }

        private MenuDelegates.MenuItem createShowDateTimeMenu()
        {
            MenuDelegates.MenuItem dateTimeMenu = new MenuDelegates.MenuItem("Show Date/Time");
            MenuDelegates.MenuItem showDateMenuItem = new MenuDelegates.MenuItem("Show Date");
            MenuDelegates.MenuItem showTimeMenuItem = new MenuDelegates.MenuItem("Show Time");

            showDateMenuItem.Selected += showDateMenuItem_Selected;
            showTimeMenuItem.Selected += showTimeMenuItem_Selected;
            dateTimeMenu.AddSubMenuItemToMenuItem(showDateMenuItem);
            dateTimeMenu.AddSubMenuItemToMenuItem(showTimeMenuItem);

            return dateTimeMenu;
        }

        private MenuDelegates.MenuItem createVersionAndSpacesMenu()
        {
            MenuDelegates.MenuItem VersionAndSpacesMenu = new MenuDelegates.MenuItem("Version And Spaces");
            MenuDelegates.MenuItem showVersionMenuItem = new MenuDelegates.MenuItem("Show Version");
            MenuDelegates.MenuItem countSpacesMenuItem = new MenuDelegates.MenuItem("Count Spaces");

            showVersionMenuItem.Selected += showVersionMenuItem_Selected;
            countSpacesMenuItem.Selected += countSpacesMenuItem_Selected;
            VersionAndSpacesMenu.AddSubMenuItemToMenuItem(showVersionMenuItem);
            VersionAndSpacesMenu.AddSubMenuItemToMenuItem(countSpacesMenuItem);

            return VersionAndSpacesMenu;
        }

        private void showDateMenuItem_Selected(MenuDelegates.MenuItem i_TheItemMenuThatWasSelected)
        {
            Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
        }

        private void showTimeMenuItem_Selected(MenuDelegates.MenuItem i_TheItemMenuThatWasSelected)
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }

        private void showVersionMenuItem_Selected(MenuDelegates.MenuItem i_TheItemMenuThatWasSelected)
        {
            Console.WriteLine("Version: 23.2.4.9805");
        }
        
        private void countSpacesMenuItem_Selected(MenuDelegates.MenuItem i_TheItemMenuThatWasSelected)
        {         
            Console.WriteLine("Please enter the line to count spaces");
            string line = Console.ReadLine();
            Console.WriteLine($@"There are {countSpaces(line)} spaces in: {line}");
        }

        private int countSpaces(string i_String)
        {
            int count = 0;

            foreach (char ch in i_String)
            {
                if (ch == ' ')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
