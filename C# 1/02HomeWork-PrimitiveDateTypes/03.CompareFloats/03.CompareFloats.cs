using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Compare floating numbers";
        Console.WriteLine("Enter first number here: ");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number here: ");
        float b = float.Parse(Console.ReadLine());
        bool comparison = (Math.Abs(a - b) < 0.000001);

        Console.WriteLine("The difference between {0} and {1} is {2}", a, b, (a - b));
        Console.WriteLine("Is it the same number? {0}",comparison);
          
    }
}
