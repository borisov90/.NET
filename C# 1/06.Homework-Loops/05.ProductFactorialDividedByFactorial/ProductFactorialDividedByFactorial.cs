using System;
using System.Numerics;

class ProductFactorialDividedByFactorial
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for N /greater than 1/: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for K /greater than 1/: ");
        BigInteger k = BigInteger.Parse(Console.ReadLine());
        BigInteger resultN = 1;
        BigInteger resultK = 1;
        BigInteger total;

        if (1 < n && n < k)
        {
            checked
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
                total = (resultN * resultK) / (resultK / resultN);
                Console.WriteLine("(N!*K!)/(K-N)! = {0}", total);
            }
        }
        else
        {
            Console.WriteLine("Enter valid number (K and N should be greater than 1, and K should be greater than n!!!)");
            return;
        }
    }
}

