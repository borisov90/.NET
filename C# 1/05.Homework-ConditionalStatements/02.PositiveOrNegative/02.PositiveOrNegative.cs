using System;

class Program
{
    public static double CheckTheSign(double number)
    {
        if (number > 0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }


    static void Main(string[] args)
    {
        double a = int.Parse(Console.ReadLine());
        double b = int.Parse(Console.ReadLine());
        double c = int.Parse(Console.ReadLine());

        double sign = 0;

        sign = sign + CheckTheSign(a);
        sign = sign + CheckTheSign(b);
        sign = sign + CheckTheSign(c);

        if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The product is zero");
        }
        else if (sign == 1 || sign == 3)
        {
            Console.WriteLine("The product is positive");
        }
        else
        {
            Console.WriteLine("The product is negative");
        }

    
    }
}

