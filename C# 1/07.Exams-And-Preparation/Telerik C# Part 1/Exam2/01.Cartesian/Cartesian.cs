﻿using System;

class Cartesian
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        if (x == 0 & y == 0)
        {
            Console.WriteLine("0");
        }
         else if (x == 0 )
        {
            Console.WriteLine("5");
        }
        else if (y == 0)
        {
            Console.WriteLine("6");
        }
        else if (y > 0 && x > 0)
        {
            Console.WriteLine("1");
        }
        else if (y > 0 && x < 0)
        {
            Console.WriteLine("2");
        }
        else if (y < 0 && x < 0)
        {
            Console.WriteLine("3");
        }
        else if (y < 0 && x > 0)
        {
            Console.WriteLine("4");
        }
    }
}
