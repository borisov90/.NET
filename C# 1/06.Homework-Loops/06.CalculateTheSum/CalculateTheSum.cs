using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter value for N:");
        decimal N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for X:");
        decimal X = int.Parse(Console.ReadLine());
        decimal sumN = 1;
        decimal sumX = 1;
        decimal temp = 0;
        decimal S = 0;
        if (1 < X & 1 < N)
        {
            for (decimal i = 1; i <= N; i++)
            {
                sumN *= i;
                Console.WriteLine("N factorial is {0}", sumN);

                for (decimal j = 1; j <= N; j++)
                {
                    sumX *= X;
                    Console.WriteLine("xN is {0}", sumX);
                    temp = sumN / sumX;
                    Console.WriteLine(" {0} ", temp);
                }
                //Console.WriteLine("The sum S = 1 + 1!/X + 2!/X2 + … + N!/XN is {0}",finalS += S);
                S += temp;
            }
            Console.WriteLine("The sum S = 1 + 1!/X + 2!/X2 + … + N!/XN is {0}", S );

        }
    }
}

