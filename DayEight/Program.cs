using System;

namespace DayEight
{
   class Program
   {
        static void CountingWords()
        {
            /*Harsh was recently gifted a book consisting of N pages. 
            Each page contains exactly M words printed on it. As he
            was bored, he decided to count the number of words in the book.`*/

           int testCase = Int32.Parse(Console.ReadLine());
           for(int x = 1; x <= testCase; x++)
           {
            string[] uInput = Console.ReadLine().Split();
            Console.WriteLine(Int32.Parse(uInput[0]) * Int32.Parse(uInput[1]));

           }
        }
        public static void Main() 
        {
            CountingWords();
        }
   } 
}