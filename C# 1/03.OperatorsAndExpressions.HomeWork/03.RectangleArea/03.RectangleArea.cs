using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Rectangle area calculator";
        Console.WriteLine("Enter width for the rectangle");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter height for the rectangle");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("Rectangle's area is {0}", width * height);
    }
}

