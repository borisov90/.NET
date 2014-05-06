using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter parameter a =  ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter parameter b =  ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter parameter c =  ");
        int c = int.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;
        double x, x1, x2, img;

        // if discriminant is smaller than 0, we have imaginary solutions, that's why I use the double with name 'img'.

        if (discriminant > 0)
        {
            x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Two Real Solutions: {0,8:f4} or  {1,8:f4}", x1, x2); 
        }
        else if (discriminant < 0)
        {
            discriminant = -discriminant;

            x = -b / (2 * a);

            img = Math.Sqrt(discriminant) / (2 * a);

            Console.WriteLine("Two Imaginary Solutions: {0,8:f4} + {1,8:f4} i or {2,8:f4} + {3,8:f4} i", x, img, x, img);
        }
        else
        {

            x = (-b + Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine("One Real Solution: {0,8:f4}", x);
        }
    }
}

