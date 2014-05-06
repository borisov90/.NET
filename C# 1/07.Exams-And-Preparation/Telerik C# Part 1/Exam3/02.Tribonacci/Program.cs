using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        BigInteger firstnumber = BigInteger.Parse(Console.ReadLine());
        BigInteger secondnumber = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdnumber = BigInteger.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());

        BigInteger[] numbers = new BigInteger[N];
        numbers[0] = firstnumber;
        numbers[1] = secondnumber;
        numbers[2] = thirdnumber;

        for (int i = 3; i < N; i++)
			{
			   numbers[i] = numbers[i-1] + numbers[i-2] + numbers[i-3];
			}
        Console.WriteLine(numbers[N-1]);
    }
}

