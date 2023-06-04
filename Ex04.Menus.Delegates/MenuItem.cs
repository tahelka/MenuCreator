using System;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        public BasicMenu m_BasicMenu;
        public event Action<MenuItem> Selected;

        public MenuItem(string i_MenuTitle)
        {
            bool isMainMenu = false;

            m_BasicMenu = new BasicMenu(i_MenuTitle, isMainMenu);
        }

        protected virtual void OnSelected()
        {
            if (Selected != null)
            {
                Selected.Invoke(this);
            }
        }

        internal void MenuItemSelected()
        {
            OnSelected();
        }

        public void AddSubMenuItemToMenuItem(MenuItem i_MenuItemToAdd)
        {
            m_BasicMenu.AddSubMenuItemToMenu(i_MenuItemToAdd);
        }
    }
}