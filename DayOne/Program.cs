

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


int[,] nums = {{14, 13, 41}, {14, 123, 13}, {10, 31, 4}};

foreach (int item in nums)
{
    Console.WriteLine("\n{0}", item);
}