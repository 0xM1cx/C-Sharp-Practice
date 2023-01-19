using System;
namespace CodeChefPracticeChallenges
{
    class Program
    {

        void AgeLimitProblem()
        {
            /*PROBLEM
              Chef wants to appear in a competitive exam. To take the exam, there are following requirements:
                1. Minimum age limit is XX (i.e. Age should be greater than or equal to XX).
                2. Age should be strictly less than YY.

                Chef's current Age is A. Find whether he is currently eligible to take the exam or not.  
            */ 
            string lineOne = Console.ReadLine();
           
            

            if(Int32.Parse(lineOne) >= 1 && Int32.Parse(lineOne) <= 1000)
            {
                for(int i = 1; i <= Int32.Parse(lineOne); i++)
                {
                    string[] input = Console.ReadLine().Split(' ');
                    if(Int32.Parse(input[2]) >= 10 && Int32.Parse(input[2]) <= 50 && Int32.Parse(input[0]) >= 20 && Int32.Parse(input[0]) <= Int32.Parse(input[1]) && Int32.Parse(input[1]) <= 40)
                    {   
                        if(Int32.Parse(input[2]) < Int32.Parse(input[1]) && Int32.Parse(input[2]) >= Int32.Parse(input[0]))
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

        public static void Main()
        {
            Program rn = new Program();
            rn.AgeLimitProblem();
        }     
    }
}