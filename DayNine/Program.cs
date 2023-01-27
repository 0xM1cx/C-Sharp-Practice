using System;

namespace DayNine
{
    class Program
    {
       static void SavingTaxes()
       {
        /*In Chefland, everyone who earns strictly more than Y per year,
        has to pay a tax to Chef. Chef has allowed a special scheme where
        you can invest any amount of money and claim exemption for it.
        
        You have earned X(X > Y) this year. Find the minimum amount of 
        money you have to invest so that you don't have to pay taxes this 
        year.*/
        int testCases = Int32.Parse(Console.ReadLine());
        for(int x = 1; x <= testCases; x++)
        {
            string[] uInput = Console.ReadLine().Split(" ");
            List<int> converted_list = new List<int>();
            foreach (var item in uInput)
            {
               converted_list.Add(Int32.Parse(item)); 
            }


            Console.WriteLine(converted_list[0] - converted_list[1]); 

        }
       }
       public static void Main() 
       {
            SavingTaxes();
       }
    }
}