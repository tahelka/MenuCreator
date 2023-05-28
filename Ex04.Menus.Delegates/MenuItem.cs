using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    class MenuItem
    {
        public event Action<MenuItem> ReportSelectedItems;
        private List<MenuItem> m_SubMenu;
        public string MenuTitle { get; set; }

        private void notifySelectedItems()
        {
            if (ReportSelectedItems != null)
            {
                ReportSelectedItems.Invoke(m_ID);

                /// which does this:
                ///foreach (ReportSickDelegate observerDelegate in m_ReportSickDelegates.GetInvocationList())
                ///{
                ///    observerDelegate.Invoke(m_ID);SelectedItems
                ///}
            }
        }
    }
}
