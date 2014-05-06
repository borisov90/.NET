using System;


class SubsetEqualsZero
{
    static void Main(string[] args)
    {
        const int numbersCounted = 5;
        double[] number = new double[5];
        bool subsetFound = false;
                      
            Console.WriteLine("Please input a number for a:");
            number[0] = double.Parse(Console.In.ReadLine());
            Console.WriteLine("Please input a number for b:");
            number[1] = double.Parse(Console.In.ReadLine());
            Console.WriteLine("Please input a number for c:");
            number[2] = double.Parse(Console.In.ReadLine());
            Console.WriteLine("Please input a number for d:");
            number[3] = double.Parse(Console.In.ReadLine());
            Console.WriteLine("Please input a number for e:");
            number[4] = double.Parse(Console.In.ReadLine());
   
  
        for (int startPos = 0; startPos < numbersCounted; startPos++)
        {
            double sum = 0;
            for (int endPos = startPos; endPos < numbersCounted; endPos++)
            {
                sum += number[endPos];
                if (sum == 0)
                {
                    Console.Write("Subset found: ");
                    subsetFound = true;
                    for (int iterator = startPos; iterator <= endPos; iterator++)
                    {
                        Console.Write("{0} ", number[iterator]);
                    }
                    Console.WriteLine();
                }
            }
        }
        if (subsetFound == false)
        {
            Console.WriteLine("No subset found.");
        }
    }
}

