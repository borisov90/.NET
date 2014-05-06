using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace QuadronacciRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstQuadronacci = BigInteger.Parse(Console.ReadLine());
            BigInteger secondQuadronacci = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdQuadronacci = BigInteger.Parse(Console.ReadLine());
            BigInteger fourQuadronacci = BigInteger.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int numberOfMembers = rows * cols;
            BigInteger nQuadronacciMember;

            if (cols == 1)
            {
                Console.WriteLine(firstQuadronacci);
            }
            else
            {
                Console.Write(firstQuadronacci + " ");
            }

            if (cols == 2)
            {
                Console.WriteLine(secondQuadronacci);
            }
            else
            {
                Console.Write(secondQuadronacci + " ");
            }

            if (cols == 3)
            {
                Console.WriteLine(thirdQuadronacci);
            }
            else
            {
                Console.Write(thirdQuadronacci + " ");
            }
            if (cols == 4)
            {
                Console.WriteLine(fourQuadronacci);
            }
            else
            {
                Console.Write(fourQuadronacci + " ");
            }

            for (int i = 5; i <= numberOfMembers; i++)
            {

                nQuadronacciMember = firstQuadronacci + secondQuadronacci + thirdQuadronacci + fourQuadronacci;
                if (i < numberOfMembers && i % cols != 0)
                {
                    Console.Write(nQuadronacciMember + " ");
                }
                else
                {
                    Console.Write(nQuadronacciMember);
                }

                firstQuadronacci = secondQuadronacci;
                secondQuadronacci = thirdQuadronacci;
                thirdQuadronacci = fourQuadronacci;
                fourQuadronacci = nQuadronacciMember;

                if (i % cols == 0 && i != numberOfMembers)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
