using System;
   
class Program
{
    static void Main(string[] args)
    {
        // input;
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        double D = double.Parse(Console.ReadLine());

        double denominator = B * D;
        double nominatorA = A / B;
        double nominatorB = C / D;

        double sum = ((nominatorA + nominatorB));
        int newsum = (int)(sum);
        int finaldenominator = (int)(denominator);
        double finalnominator = (denominator * sum);
        int finnomerator = (int)(finalnominator);
   
        if (sum > 1)
        {
            Console.WriteLine(newsum);
        }
        if (sum < 1)
        {
            Console.WriteLine("{0:f20}", sum);
        }
        Console.WriteLine("{0}/{1}", finnomerator, finaldenominator);
          
   
   
   
    }
}