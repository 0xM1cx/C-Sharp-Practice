using System;
using System.IO;
using System.Collections.Generic;

namespace CalorieCounting
{
    class Count
    {
        static void Main(string[] args)
        {
            // C:\Users\Asus\OneDrive\Documents\C-Sharp-Practice\advent-of-code\CalorieCounting
            string[] lines = File.ReadAllLines(".\\input.txt");
            int calorieSum = 0;
            List<int> calories = new List<int>();
    

            int biggest = 0;
            foreach(var line in lines)
            {
                if(line.Length > 0)
                {
                    calorieSum += Convert.ToInt32(line);
                    
                }else{
                    calories.Add(calorieSum);
                    calorieSum = 0;
                }
            }

            foreach(var e in calories)
            {
               if(e > biggest)
               {
                biggest = e;
               }
            }

            Console.WriteLine("The biggest number of calories is {0}", biggest);
        }
    }
}