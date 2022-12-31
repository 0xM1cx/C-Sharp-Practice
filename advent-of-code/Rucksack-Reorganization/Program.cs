using System;
using System.IO;
using System.Collections.Generic;

namespace Program
{
    class RucksackReorganization 
    {
        public static void Main(string[] args)
        {
            string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string[] lines = File.ReadAllLines(".\\input.txt");

            foreach (string line in lines)
            {
                int lineLength = line.Length;
                
                List<char> firstPart = new List<char>(); 
                List<char> secondPart = new List<char>();
                // Append the first part of the array to another array
                for(int i = 0; i < (lineLength/2); i++)
                {
                    firstPart.Add(line[i]);
                }

                // Appnding the second half of char of line to the secondPart List
                for(int i = (lineLength/2); i < lineLength; i++)
                {
                    secondPart.Add(line(i));
                }

                // Comparing the items in both list to see which is char is shared
                
            }

        }
    }
}