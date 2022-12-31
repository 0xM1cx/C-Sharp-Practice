using System;
using System.IO;
using System.Collections.Generic;

namespace Program
{
    class RucksackReorganization 
    {

        public int Total = 0;
        public int CalculatePriorityPoints(List<char> item_dups, string letters)
        {
            
            foreach (char dup in item_dups)
            {
                Total += letters.IndexOf(dup) + 1;
            }
            return Total;
        }

        public static void Main(string[] args)
        {
            string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string[] lines = File.ReadAllLines(".\\input.txt");
            List<char> item_duplicate = new List<char>();
            RucksackReorganization RuckReorg = new RucksackReorganization();
            int TotalPoints = 0;
            int lineLength = 0;
            List<char> firstPart = new List<char>(); 
            List<char> secondPart = new List<char>();

            foreach (string line in lines)
            {
                // Getting the line length for every line in the file
                lineLength = line.Length;
                
                // Append the first part of the array to another array
                for(int i = 0; i < (lineLength/2); i++)
                {
                    firstPart.Add(line[i]);
                }

                // Appnding the second half of char of line to the secondPart List
                for(int i = (lineLength/2); i < lineLength; i++)
                {
                    secondPart.Add(line[i]);
                }

                // Comparing the items in both list to see which is char is shared
                foreach (char item in firstPart)
                {
                    if(secondPart.Contains(item))
                    {
                        item_duplicate.Add(item);
                    }
                }
                
                
            }
            // Get the total priority points from all the duplicate items
            TotalPoints = RuckReorg.CalculatePriorityPoints(item_duplicate, letters);
            // Displaying the total priority points of the items
            Console.WriteLine("The total priority of all the duplicates is {0}", TotalPoints);

        }
    }
}