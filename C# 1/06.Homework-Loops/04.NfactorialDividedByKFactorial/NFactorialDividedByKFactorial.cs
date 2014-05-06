using System;
using System.Numerics;

class FactorialDivide
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for N /greater than 1/: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for K /greater than 1/: ");
        BigInteger k = BigInteger.Parse(Console.ReadLine());
        BigInteger resultN = 1;
        BigInteger resultK = 1;

        if (1 < k && k < n)
        {
            for (BigInteger i = n; n > 1; n--)
            {
                resultN *= n;
                //Console.WriteLine(resultN);
            }
            for (BigInteger j = k; k > 1; k--)
            {
                resultK *= k;
                //Console.WriteLine(resultK);
            }
            Console.WriteLine("N!/K! = {0}", resultN / resultK);
        }
        else
        {
            Console.WriteLine("Enter valid number (N and K should be greater than 1, and N should be greater than K!!!)");
            return;
        }
    }
}

