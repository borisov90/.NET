using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter radius : ?");
        float radius = float.Parse(Console.ReadLine());
        float pi = 3.1415926f;
        float perimeter = (2*(pi*radius));
        float area = pi*(radius*radius);
        Console.WriteLine("The perimeter of a circle with radius {0} is {1}", radius, perimeter);
        Console.WriteLine("The area of this circle is {0}", area);
    }
}

