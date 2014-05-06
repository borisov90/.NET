using System;



class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int m = n / 100;

        if (m % 10 == 7)
        {
            Console.WriteLine("The third number is 7");
        }

        else
        {
            Console.WriteLine("The third number is not 7");
        }
    }
}

