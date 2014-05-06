using System;


namespace _11.ExchangeValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a = a*b);
            Console.WriteLine(b = a/b);
            Console.WriteLine(a = a/b);
            Console.WriteLine(" {0} is now {1}", a, b);

        }
    }
}
