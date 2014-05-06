using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CopyrightSymbol
{
    class Program
    {
        static void Main(string[] args)
        {

            char copyright = '\u00a9';
            Console.OutputEncoding = Encoding.Unicode;
            

            double top = 1;
            Console.WriteLine("Write a number: ");
            int row = int.Parse(Console.ReadLine());
            double col = 2 * row - 1;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (j < (col / 2 - top / 2) || j > (col / 2 + top / 2 - 1))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(copyright);
                    }
                }
                top = top + 2;
                Console.WriteLine();


            }

        }
    }
}
