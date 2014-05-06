using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAttempt
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberA = double.Parse(Console.ReadLine());
            double numberB = double.Parse(Console.ReadLine());
            double numberC = double.Parse(Console.ReadLine());
            double numberD = double.Parse(Console.ReadLine());
            double fraction1 = Math.Round((numberA / numberB),20);
            double fraction2 = Math.Round((numberC / numberD), 20);
            double fulpies = fraction1 + fraction2;
            if (fulpies > 1)
            {
                Console.WriteLine((int)fulpies);
            }
            else
            {
                Console.WriteLine("{0:f20}", fulpies);
            }
            
            double denominator = numberB * numberD;
            double nominator = fulpies * denominator;
            Console.WriteLine("{0}/{1}", nominator, denominator);
        }
    }
}
