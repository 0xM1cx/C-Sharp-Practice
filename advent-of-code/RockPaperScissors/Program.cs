using System;
using System.Collections.Generic;
using System.IO;

// This is the 2nd day of the Advent of Code Challege.
// https://adventofcode.com/2022/day/2

namespace MainProgram
{
    class RPS
    {

        public int Score(string[] currentRound)
        {
            // This function deals will the game.
            // Like when the user has X(Rock) and the enemy draws A(Rock) it will be a draw, returning 3 as stated in the rules.
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

            List<string> choices = new List<string>(); // Declared a list for the possible player choices.
            
            string[] lines = File.ReadAllLines(".\\input.txt"); // Get the input from the input.txt file
            string[] currentRound = new string[2]; // For every 2 letters, like A X, in every line in the file, it will be stored here


            //  These will be the possible values for the users to have. 
            // X is Rock, Y is Paper and Z is Scissors
            choices.Add("X"); 
            choices.Add("Y");
            choices.Add("Z");
            
            RPS rps = new RPS(); // made an object so that I can access the Score() function
            int Total = 0; // the total score from all the rounds/lines

            foreach (string line in lines) // This is loop through every line in tne input.txt file
            {
                currentRound = line.Split(' '); // For every line the File it will split the string into 2, these are strings separted by space
                int roundScore = rps.Score(currentRound); // This invoked the Score() and return an integer score, depending on the values of the user and the enemy
                

                // This determined the index for the player input, because this will be used as added points later on.
                // Using X will give additional 1 point, Y will be 2 points and Z will be 3 points.
                int index = choices.FindIndex(a => a.Contains(currentRound[1])); 
                
                Total += roundScore + (index + 1); // This adds the score the player got depending in the comparison made and the index for which option the player used 
            }


            Console.WriteLine("The Total Score is {0}", Total);            // Outputs the total score of all the rounds

            
        }
    }
}