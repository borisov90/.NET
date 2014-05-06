using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter positive integer number 1: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter positive integer number 2: ");
        int b = int.Parse(Console.ReadLine());
        int p = 0;

        for (int n = a; n <= b; n++)
        {
            if (n % 5 == 0)
            {
                p = p + 1;
                Console.WriteLine(n);
            }
        }
        Console.WriteLine("The numbers wich can be devided by 5 without remain are {0}", p);
    }
}

