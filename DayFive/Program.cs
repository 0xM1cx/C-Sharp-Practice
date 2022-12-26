using System;

namespace ConstructorPractice
{
    class Test
    {
        string name = "Shawn";
        int age;
        Test(int age)
        {
            this.age = age;
        }

        public void bonai(string nickname)
        {
            Console.WriteLine("Before assigning a new value: {0}", this.name);
            this.name = nickname;
            Console.WriteLine("The object of this:  {0}", this.name);
        }

        static void Main(string[] args)
        {
            Console.Write("How old are you: ");
            // int age = Convert.ToInt32(Console.ReadLine());
            Test test = new Test(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("I am now {0}", test.age);
            
        }

    }
}