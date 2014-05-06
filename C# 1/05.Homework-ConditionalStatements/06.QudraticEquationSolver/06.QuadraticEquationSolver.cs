using System;


class QudraticEquationSolver
{
    public static void QudraticSolver(double a, double b, double c)
    {
            double sqrtpart = b * b - 4 * a * c;
            double x, x1, x2, img;
            if (sqrtpart > 0)
            {
                x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                x2 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine("Two Real Solutions: {0,8:f4} or {1,8:f4}", x1, x2);
            }
            else if (sqrtpart < 0)
            {
                sqrtpart = -sqrtpart;
                x = -b / (2 * a);
                img = System.Math.Sqrt(sqrtpart) / (2 * a);
                Console.WriteLine("Equation doesn't have any real roots, but it does have two Imaginary Solutions / not real roots/ : {0,8:f4} + {1,8:f4}  or {2,8:f4} + {3,8:f4}", x, img, x, img);
            }
            else
            {
                x = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine("One Real Solution: {0,8:f4}", x);
            }
    }

    
    static void Main(string[] args)
    {
        Console.WriteLine("Enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());

        QudraticSolver(a, b, c);


    }
}

