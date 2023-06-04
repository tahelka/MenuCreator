namespace Ex04.Menus.Test
{
    class Program
    {
        public static int Main()
        {
            TestMenuUsingDelegate delegateTest = new TestMenuUsingDelegate();
            delegateTest.CreateAndRunMenu();

            TestMenuUsingInterface interfaceTest = new TestMenuUsingInterface();
            interfaceTest.Start();
            return 0;
        }
    }
}
