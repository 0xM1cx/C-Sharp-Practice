using System;
using System.Collections.Generic;
using System.IO;

namespace MainProgram
{
    class RPS
    {

        public int Score(string[] currentRound)
        {
            
            if(currentRound[1] == "X" && currentRound[0] == "A")
            {
                return 3;
            }
            else if(currentRound[1] == "Y" && currentRound[0] == "B"){
                return 3;
            }
            else if(currentRound[1] == "Z" && currentRound[0] == "C")
            {
                return 3;
            }
            else if(currentRound[1] == "X" && currentRound[0] == "C"){
                return 6;
            }
            else if(currentRound[1] == "X" && currentRound[0] == "B"){
                return 0;
            }
            else if(currentRound[1] == "Y" && currentRound[0] == "A"){
                return 6;
            }
            else if(currentRound[1] == "Y" && currentRound[0] == "C"){
                return 0;
            }
            else if(currentRound[1] == "Z" && currentRound[0] == "A"){
                return 0;
            }
            else if(currentRound[1] == "Z" && currentRound[0] == "B"){
                return 6;
            }

            return 0;
        }


        public static void Main(string[] args)
        {
            // var list = new List<KeyValuePair<string, int>>();
            List<string> choices = new List<string>();
            
            string[] lines = File.ReadAllLines(".\\input.txt");
            string[] currentRound = new string[2];

            choices.Add("X");
            choices.Add("Y");
            choices.Add("Z");
            
            RPS rps = new RPS();
            int Total = 0;

            foreach (string line in lines)
            {
                currentRound = line.Split(' ');
                int roundScore = rps.Score(currentRound);
                
                int index = choices.FindIndex(a => a.Contains(currentRound[1]));
                
                Total += roundScore + (index + 1);

            }


            Console.WriteLine("The Total Score is {0}", Total);            

            
        }
    }
}