﻿void ProblemOne(){
// Problem 1
// STATUS: COMPLETED
/*Write a program to store elements in an array and print it.*/
    int[] arr = new int[50];
    int i = 0, userInput;
    do
    {
        Console.WriteLine("INPUT:  ");
        userInput = Convert.ToInt32(Console.ReadLine());
        arr[i] = userInput;
        i++;

    } while(userInput != 0);

    try
    {
        for(int b = 0; b <= arr.Length; b++){
            if(b % 10 == 0){
                Console.WriteLine();
            }

            if(arr[b] != 0){
                Console.Write(arr[b] + "\t");
            }
        }    
    }
    catch (System.IndexOutOfRangeException)
    {
        Environment.Exit(0);
    }

}



void Main(){
    ProblemOne();    
}

Main();