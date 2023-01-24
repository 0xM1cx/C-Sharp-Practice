using System;

namespace DaySeven
{
    class Program
    {
        static void CoutingWords()
        {
            int testCase = Int32.Parse(Console.ReadLine());
            for(int x = 1; x <= testCase; x++)
            {
                        
            }
        }
        static void getTotalPrizeMoney()
        {
            /*In a coding contest, there are prizes for the top rankers.
            The prize scheme is as follows:
            - Top 10 participants receive rupees X each
            - Participants with rank 11 to 100 (both inclusive) receive
            rupees Y each.
            */

            int testCases = Int32.Parse(Console.ReadLine());
            for(int x = 0; x < testCases; x++)
            {
                string[] uInput = Console.ReadLine().Split(' ');
                Console.WriteLine((Int32.Parse(uInput[0]) * 10) + (90 * Int32.Parse(uInput[1l])));
            }
        }
        static void Parity()
        {
            /*Ashu and Arvind participated in a coding contest, as a 
            result of which  they received N chocolates. Now they want to 
            divide the chocolate between them equally.
            
            Can you help them by deciding if its possible for them to divide
            all the N chocolates in such a way that they each get an equal
            number of chocolates
            */
            int testCases = Int32.Parse(Console.ReadLine());
            for(int x = 1; x <= testCases; x++)
            {
                int nChocolates =   Int32.Parse(Console.ReadLine()); 
                if(nChocolates % 2 == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
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
            getTotalPrizeMoney();
        }
    }
}