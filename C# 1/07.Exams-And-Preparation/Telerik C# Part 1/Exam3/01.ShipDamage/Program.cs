using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShipDamage
{
    class Program
    {
        static void Main(string[] args)
        {
            int sx1 = int.Parse(Console.ReadLine());
            int sy1 = int.Parse(Console.ReadLine());
            int sx2 = int.Parse(Console.ReadLine());
            int sy2 = int.Parse(Console.ReadLine());

            int h = int.Parse(Console.ReadLine());

            int cx1 = int.Parse(Console.ReadLine());
            int cy1 = int.Parse(Console.ReadLine());
            int cx2 = int.Parse(Console.ReadLine());
            int cy2 = int.Parse(Console.ReadLine());
            int cx3 = int.Parse(Console.ReadLine());
            int cy3 = int.Parse(Console.ReadLine());

            int sxMin = Math.Min(sx1, sx2);
            int sxMax = Math.Max(sx1, sx2);
            int syMin = Math.Min(sy1, sy2);
            int syMax = Math.Max(sy1, sy2);

            int distanceone = 2 * h - cy1;
            int distancetwo = 2 * h - cy2;
            int distancethree = 2 * h - cy3;

            int damage = 0;

            if (((distanceone > syMin) && (distanceone < syMax)) && ((cx1 > sxMin) && (cx1 < sxMax)))
            {
                damage += 100; //inside
            }
            if (((distancetwo > syMin) && (distancetwo < syMax)) && ((cx2 > sxMin) && (cx2 < sxMax)))
            {
                damage += 100;
            }
            if (((distancethree > syMin) && (distancethree < syMax)) && ((cx3 > sxMin) && (cx3 < sxMax)))
            {
                damage += 100; // inside
            }
            if (((distanceone == syMin) || (distanceone == syMax)) && ((cx1 > sxMin) && (cx1 < sxMax)))
            {
                damage += 50; //lines
            }
            if (((distancetwo == syMin) || (distancetwo == syMax)) && ((cx2 > sxMin) && (cx2 < sxMax)))
            {
                damage += 50; //lines
            }
            if (((distancethree == syMin) || (distancethree == syMax)) && ((cx3 > sxMin) && (cx3 < sxMax)))
            {
                damage += 50; //lines
            }
            if (((distanceone > syMin) && (distanceone < syMax)) && ((cx1 == sxMin) || (cx1 == sxMax)))
            {
                damage += 50; //sides
            }
            if (((distancetwo > syMin) && (distancetwo < syMax)) && ((cx2 == sxMin) || (cx2 == sxMax)))
            {
                damage += 50; //sides
            }
            if (((distancethree > syMin) && (distancethree < syMax)) && ((cx3 == sxMin) || (cx3 == sxMax)))
            {
                damage += 50; //sides
            }
            if (((distanceone == syMin) || (distanceone == syMax)) && ((cx1 == sxMin) || (cx1 == sxMax)))
            {
                damage += 25;
            }
            if (((distancetwo == syMin) || (distancetwo == syMax)) && ((cx2 == sxMin) || (cx2 == sxMax)))
            {
                damage += 25;
            }
            if (((distancethree == syMin) || (distancethree == syMax)) && ((cx3 == sxMin) || (cx3 == sxMax)))
            {
                damage += 25;
            }
            Console.WriteLine(damage + "%");
        }
    }
}