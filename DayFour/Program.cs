// 12/17/2022
// Day Four of C# Coding Practice/Review

class Program{

    static void swapNums(int a, int b){
        Console.WriteLine("Values before swap occured\n a:{0}\n b:{1}", a, b);
        int x = b;
        b = a;
        a = x;

        Console.WriteLine("Values after swap occured\n a:{0}\n b:{1}", a, b);

        

    }


    static int getAverage(int[] arr){
        int sum = 0;
        foreach (var item in arr)
        {
            sum += item;
        }

        int avg = sum / arr.Length;
        return avg;
    }

    static void Main(string[] args){
        string[] names = new string[2];
        names[0] = "Shawn";
        names[1] = "Crystal";
        int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        Console.WriteLine("The average of the numbers in the array is {0}",getAverage(arr));
        Console.WriteLine("I'm {0} and this is my girlfriend {1}\n\n", names[0], names[1]);

        swapNums(1, 2);
    
    }
}