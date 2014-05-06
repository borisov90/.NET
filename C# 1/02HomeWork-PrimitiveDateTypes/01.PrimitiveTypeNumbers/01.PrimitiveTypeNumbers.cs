using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //        sbyte (-128 to 127): signed 8-bit
        //byte (0 to 255): unsigned 8-bit
        //short (-32,768 to 32,767): signed 16-bit
        //ushort (0 to 65,535): unsigned 16-bit
        //int (-2,147,483,648 to 2,147,483,647): signed 32-bit
        //uint (0 to 4,294,967,295): unsigned 32-bit

        ushort a = 52130;
        sbyte b = -115;
        int c = 4825932;
        byte d = 97;
        short e = -10000;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
    }
}

