using System;

class Program
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
       
        double n = double.Parse(Console.ReadLine());
        double d = 0;
        double i;
        
       

        for (i = 1; i <= n-3; i++)
        {
            d = c + a + b;
            a = b;
            b = c;
            c = d;
        }
        Console.WriteLine(d);
       
    }
}

