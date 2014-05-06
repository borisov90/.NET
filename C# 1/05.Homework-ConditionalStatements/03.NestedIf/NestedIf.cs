using System;


class NestedIf
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number 1:");
        double a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 2:");
        double b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 3:");
        double c = int.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("The greatest of these numbers is: {0}", a);
            }
            else if (a < c)
            {
                Console.WriteLine("The greatest of these numbers is: {0}", c);
            }
        }
        else if (a < b)
        {
            if (b > c)
            {
                Console.WriteLine("The greatest of these numbers is: {0}", b);
            }
            else if (b < c)
            {
                Console.WriteLine("The greatest of these numbers is: {0}", c);
            }
        }
    }
}

