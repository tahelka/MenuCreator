using System;

namespace Ex04.Menus.Interfaces
{
    public class SpaceCount : MenuItem, IActionable
    {
        public SpaceCount() : base("Count spaces")
        {
        }

        public void Action()
        {
            Console.WriteLine("Please enter the line to count spaces");
            string line = Console.ReadLine();
            Console.WriteLine($@"There are {countSpaces(line)} space in: {line}");
        }

        private int countSpaces(string i_String)
        {
            int count = 0;

            foreach(char ch in i_String)
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
