using System;

class GCD
{
    static void Main(string[] args)
    {
        int firstNumber, secondNumber;
        int GCD = 0;
        int temp = 0;

        Console.WriteLine("Enter first number");
        firstNumber = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        secondNumber = Int32.Parse(Console.ReadLine());

        if (firstNumber < secondNumber)
        {
            temp = secondNumber;
            secondNumber = firstNumber;
            firstNumber = temp;
        }
        while (secondNumber != 0)
        {
            GCD = firstNumber % secondNumber;
            firstNumber = secondNumber;
            if (GCD == 0)
            {
                GCD = secondNumber;
                secondNumber = 0;  
                //break;  
            }
            else
            {
                secondNumber = GCD; 
            }
        }
        Console.WriteLine("GCD is {0}", GCD);
    }
}

