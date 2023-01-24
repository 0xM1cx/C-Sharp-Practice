using System;

namespace DaySeven
{
    class Program
    {
        static void ChefOnDate()
        {
            /*Chef took X dollars with him, and was quite sure that this would
            be enough to pay th bill. At the end, the waiter brought a bill of Y
            dollars. Print "YES" if Chef has enough money to pay the bill, or "NO"
            if he has to borrow from his girlfriend and leave a bad impression on her
            */

            int testCases = Int32.Parse(Console.ReadLine());
            for(int i = 1; i <= testCases; i++)
            {
                string[] uInput = Console.ReadLine().Split(' ');
                if (Int32.Parse(uInput[0]) >= Int32.Parse(uInput[1]))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
        public static void Main()
        {
            ChefOnDate();
        }
    }
}