using System;

namespace Tree
{
    class Tree
    {


        public void NumberSquare()
        {
            for (int i = 5; i >= 1; i--)
            {
                for(int j = 5; j >= i; j--)
                {
                    Console.Write(j);
                }
                for(int b = 1; b < i; b++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.NumberSquare();
        }
    }
}