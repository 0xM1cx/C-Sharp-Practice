using System;

namespace Program
{
   class Sample
   {
        public static void Main()
        {
            int testCases = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
               int squats = Int32.Parse(Console.ReadLine());
               Console.WriteLine(squats * 15); 
            }
        }
   } 
}