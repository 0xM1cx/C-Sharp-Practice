

Console.WriteLine("Number: ");
int userInput = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("{0}", userInput);

// Arrays Practice
int[] agesOfStudents = {17, 18, 19, 20, 17, 18, 20, 19};

foreach (int age in agesOfStudents)
{
    Console.WriteLine(age);
}


// Multidimensional Arrays

Console.WriteLine();
int[,] nums = {{14, 13, 41}, {14, 123, 13}, {10, 31, 4}};

// foreach (int item in nums)
// {
//     Console.WriteLine("\n{0}", item);
// }

Console.WriteLine(nums[1,0]); // 14
Console.WriteLine(nums[0,1]); // 13
Console.WriteLine(nums[2,0]); // 10
Console.WriteLine(nums[2,1]); // 31


// Jagged Array

string[][] names = {
    new string[] {"SHAWN", "MICHAEL", "SUDARIA"},
    new string[] {"CRYSTAL", "NIKKI", "PATRICIA", "JOHN", "JESSICA"}
};

for (int i = 0; i < names.Length; i++)
{
    for(int j = 0; j < names[i].Length; j++)
    {
        Console.WriteLine(names[i][j]);
    }
}

Console.WriteLine("My name is {0} {1} {2}", names[0][0], names[0][1], names[0][2]);