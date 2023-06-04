
namespace Ex04.Menus.Delegates
{
    public class MainMenu 
    {
        public BasicMenu m_BasicMenu;

        public MainMenu(string i_MenuTitle)
        {
            bool isMainMenu = true;

            m_BasicMenu = new BasicMenu(i_MenuTitle, isMainMenu);  
        }
       
        public void RunMenu()
        {
            m_BasicMenu.RunMenu();
        }

        public void AddSubMenuItemToMainMenu(MenuItem i_MenuItemToAdd)
        {
            m_BasicMenu.AddSubMenuItemToMenu(i_MenuItemToAdd);
        }
    } 
}