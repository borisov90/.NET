using System;



class OrderByDescendingOrder
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
            if (b > c)
            {
                Console.WriteLine("{0}, {1}, {2}", a, b, c);
            }
            else if (b < c)
            {
                Console.WriteLine("{0}, {1}, {2}", a, c, b);
            }
        }
        else if (b > a)
        {
             if (a > c)
            {
                Console.WriteLine("{0}, {1}, {2}", b, a, c);
            }
            else if (a < c)
            {
                Console.WriteLine("{0}, {1}, {2}", b, c, a);
            }
        }
        else if (c > a)
        {
             if (a > b)
            {
                Console.WriteLine("{0}, {1}, {2}", c, a, b);
            }
            else if (a < b)
            {
                Console.WriteLine("{0}, {1}, {2}", c, b, a);
            }
        }
    }
}

