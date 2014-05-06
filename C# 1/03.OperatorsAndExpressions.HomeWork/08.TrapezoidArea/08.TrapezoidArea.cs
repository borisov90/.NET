using System;


class TrapezoidArea
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the trapezoid's side a: ");
        int sideA = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the trapezoid's side b: ");
        int sideB = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the trapezoid's height: ");
        int heightH = int.Parse(Console.ReadLine());

        int area = (((sideA + sideB) / 2) * heightH);

        Console.WriteLine("The trapezoid's area is {0}", area);

    }
}
