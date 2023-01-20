using System;

namespace WaterConsumtion
{
   class Program
   {
        public static void Main()
        {
            int testCases = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
               int input = Int32.Parse(Console.ReadLine());
               if (input >= 2000)
               {
                    Console.WriteLine("YES");
               }
               else
               {
                    Console.WriteLine("NO");
               } 
            }
        }
   } 
}