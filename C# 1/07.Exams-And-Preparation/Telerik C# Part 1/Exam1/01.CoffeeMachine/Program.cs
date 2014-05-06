using System;


class Program
{
    static void Main(string[] args)
    {
        double fivestotal = double.Parse(Console.ReadLine());
        double tenstotal = double.Parse(Console.ReadLine());
        double twentiestotal = double.Parse(Console.ReadLine());
        double fiftiestotal = double.Parse(Console.ReadLine());
        double dollarsvalue = double.Parse(Console.ReadLine());
        double moneyput = double.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        double fives = 0.05;
        double tens = 0.1;
        double twenties = 0.2;
        double fifties = 0.5;
        double change = moneyput - price;
        double total;
        double fivesvalue = fivestotal * fives;
        double tensvalue = tenstotal * tens;
        double twentiesvalue = twentiestotal * twenties;
        double fiftiesvalue = fiftiestotal * fifties;
        total = fivesvalue + tensvalue + twentiesvalue + fiftiesvalue + dollarsvalue;
        if (moneyput >= price && change <= total)
        {
            Console.WriteLine("Yes {0:f2}", total - change);
        }
        else if (moneyput < price)
        {
            Console.WriteLine("More {0:f2}", price - moneyput);
        }
        else if (moneyput > price && change > total)
        {
            Console.WriteLine("No {0:f2}", change - total);
        }
    }
}

