using System;

class Program
{
    static void Main()
    {
        Console.Title = "What will my age be in 10 years?";
        Console.WriteLine("Please enter your age here: ");
        int i = int.Parse(Console.ReadLine());
        Console.WriteLine("Your age in 10 years will be: {0}", i + 10);
    }
}

