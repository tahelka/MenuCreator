using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    class Program
    {
        public static int Main()
        {
            TestMenuUsingDelegate delegateTest = new TestMenuUsingDelegate();
            delegateTest.CreateAndRunMenu();

            return 0;
        }
    }
}
