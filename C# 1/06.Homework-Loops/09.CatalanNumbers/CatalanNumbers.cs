using System;
using System.Numerics;
using System.Threading;

class CatalanNumbers
{
    static double Factorial(double n)
    {
        double Nfactorial = 1;
        for (double i = 1; i <= n; i++)
        {
            Nfactorial = Nfactorial * i;
        }
        return Nfactorial;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        double n = int.Parse(Console.ReadLine());
        double catalanNumber = Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));
        Console.WriteLine("Catalan Number = {0}", catalanNumber);
    }
}

