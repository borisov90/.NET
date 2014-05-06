using System;


class VariableChoice
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a variable type. Press 1 for int, 2 for double, 3 for string");
        byte choice = byte.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: int firstChoise = int.Parse(Console.ReadLine());
                Console.WriteLine(firstChoise + 1);
                break;
            case 2: double secondChoise = double.Parse(Console.ReadLine());
                Console.WriteLine(secondChoise + 1);
                break;
            case 3: string thirdChoise = Console.ReadLine();
                Console.WriteLine(thirdChoise + "*");
                break;
            default: Console.WriteLine("Incorrect type chosen");
                break;

        }
    }
}

