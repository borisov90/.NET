using System;

class BonusScores
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number from 1 to 9, to calculate the bonus:");
        int i = int.Parse(Console.ReadLine());

        switch (i)
        {

            case 0: Console.WriteLine("Invalid number. Try again with number ranging from 1 to 9");
                return;
            case 1:
            case 2:
            case 3:
                i = i * 10;
                Console.WriteLine(i);
                break;
            case 4:
            case 5:
            case 6:
                i = i * 100;
                Console.WriteLine(i);
                break;
            case 7:
            case 8:
            case 9:
                i = i * 1000;
                Console.WriteLine(i);
                break;
            default: Console.WriteLine("Invalid number. Try again with number ranging from 1 to 9");
                break;
        }
    }
}

