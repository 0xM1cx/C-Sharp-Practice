using System;

namespace ConstructorPractice
{
    class Test
    {
        string name = "Shawn";

        Test(string nickname)
        {
            Console.WriteLine("Before assigning a new value: {0}", this.name);
            this.name = nickname;
            Console.WriteLine("The object of this:  {0}", this.name);
        }

        static void Main(string[] args)
        {
            Test test = new Test("Shun");
            Console.WriteLine("The object of test:  {0}",test.name);
        }
    }
}