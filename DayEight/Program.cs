using System;

namespace DayEight
{
   class Program
   {
        static void SecondMaxOfThreeNumbers()
        {
            /*Write a program that accepts sets of three numbers, and 
            prints the second-maximum number among the three.*/

            string[] N = Console.ReadLine().Split(" ");
            int[] n = new int[3];
            foreach (string item in N)
            {
                n.Append(Int32.Parse(item));
            }

            foreach(int item in n)
            {
                Console.WriteLine(TypeOf(item));
            }

            
        }
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
            SecondMaxOfThreeNumbers();
        }
   } 
}