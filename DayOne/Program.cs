

Console.WriteLine("Number: ");
int userInput = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("{0}", userInput);

// Arrays Practice
int[] agesOfStudents = {17, 18, 19, 20, 17, 18, 20, 19};

foreach (int age in agesOfStudents)
{
    Console.WriteLine(age);
}