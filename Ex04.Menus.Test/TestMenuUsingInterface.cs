using Ex04.Menus.Interfaces;
using Version = Ex04.Menus.Interfaces.Version;

namespace Ex04.Menus.Test
{
    internal class TestMenuUsingInterface
    {
        private MainMenu m_Menu;

        private void createMainMenu()
        {

            m_Menu = new MainMenu("Interface Main Menu");

            MenuItem showDateTimeMenu = createShowDateTimeMenu();
            MenuItem infoMenu = createShowInfoMenu();

            m_Menu.Menu.SubItems.Add(showDateTimeMenu);
            m_Menu.Menu.SubItems.Add(infoMenu);

        }

        private MenuItem createShowInfoMenu()
        {
            MenuItem showInfoMenuItem = new MenuItem("Show info");
            Version versionAction = new Version();
            SpaceCount spaceCountAction = new SpaceCount();

            showInfoMenuItem.SubItems.Add(versionAction);
            showInfoMenuItem.SubItems.Add(spaceCountAction);

            return showInfoMenuItem;
        }

        private MenuItem createShowDateTimeMenu()
        {
            MenuItem showDateTimeMenuItem = new MenuItem("Show Date/Time");
            Date showDateAction = new Date();
            Time showTimeAction = new Time();

            showDateTimeMenuItem.SubItems.Add(showDateAction);
            showDateTimeMenuItem.SubItems.Add(showTimeAction);

            return showDateTimeMenuItem;
        }

        public void Start()
        {
            createMainMenu();
            m_Menu.Show();
        }
    }
}
