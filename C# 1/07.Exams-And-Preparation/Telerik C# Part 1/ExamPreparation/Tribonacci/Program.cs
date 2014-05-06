using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tribonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            int linesInput = int.Parse(Console.ReadLine());
            int lines = 0;


            for (int i = 1; i <= linesInput; i++)
            {
                lines += i;
            }

            long[] arr = new long[lines];
            arr[0] = a;
            arr[1] = b;
            arr[2] = c;

            for (int i = 3; i < lines; i++)
            {
                long result = a + b + c;
                arr[i] = result;

                a = b;
                b = c;
                c = result;
            }

            int counter = 1;
            int index = 0;

            for (int i = 0; i < linesInput; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    Console.Write("{0}", arr[index]);
                    if (j != counter - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    index++;
                }
                counter++;
            }
        }
    }
}
