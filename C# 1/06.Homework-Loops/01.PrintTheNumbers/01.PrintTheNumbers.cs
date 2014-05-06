using System;

class PrintTheNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number n:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

