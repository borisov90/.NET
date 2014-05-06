using System;

class Program
{
    static void Main(string[] args)
    {
        int px1 = int.Parse(Console.ReadLine());
        int py1 = int.Parse(Console.ReadLine());
        int px2 = int.Parse(Console.ReadLine());
        int py2 = int.Parse(Console.ReadLine());

        int fx = int.Parse(Console.ReadLine());
        int fy = int.Parse(Console.ReadLine());

        int d = int.Parse(Console.ReadLine());

        int pxMax = Math.Max(px1, px2);
        int pxMin = Math.Min(px1, px2);
        int pyMax = Math.Max(py1, py2);
        int pyMin = Math.Min(py1, py2);

        int distance = fx + d;
        int damage = 0;

        if (((distance >= pxMin) && (distance <= pxMax)) && ((fy >= pyMin) && (fy <= pyMax)))
        {
            damage += 100; //direct hit
        }
        if (((distance >= pxMin) && (distance <= pxMax)) && ((fy + 1 >= pyMin) && (fy+1 <= pyMax)))
        {
            damage += 50;
        }
        if (((distance >= pxMin) && (distance <= pxMax)) && ((fy - 1 >= pyMin) && (fy -1 <= pyMax)))
        {
            damage += 50;
        }
        if (((distance + 1>= pxMin) && (distance + 1 <= pxMax)) && ((fy >= pyMin) && (fy <= pyMax)))
        {
            damage += 75;
        }
        Console.WriteLine(damage + "%");
    }
}

