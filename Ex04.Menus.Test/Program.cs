namespace Ex04.Menus.Test
{
    public class Program
    {
        public static int Main()
        {
            TestMenuUsingDelegate delegateTest = new TestMenuUsingDelegate();
            TestMenuUsingInterface interfaceTest = new TestMenuUsingInterface();

            delegateTest.CreateAndRunMenu();
            interfaceTest.CreateAndShowMenu();

            return 0;
        }
    }
}
