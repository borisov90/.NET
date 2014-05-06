using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers a, b and c: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of those numbers is {0}", (a + b + c));
    }
}

