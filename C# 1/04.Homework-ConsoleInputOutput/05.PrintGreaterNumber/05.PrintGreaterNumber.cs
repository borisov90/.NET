using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int bi = int.Parse(Console.ReadLine());

        Console.WriteLine("The greater number is: {0}", Math.Max(i, bi));
       

    }
}

