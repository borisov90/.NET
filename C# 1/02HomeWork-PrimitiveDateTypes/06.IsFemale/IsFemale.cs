using System;

class IsFemale
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your gender? ");
        string gender = Console.ReadLine();
        bool isFemale = true;
        if (gender == "female")
        {
            isFemale = true;
        }
        else
        {
            isFemale = false;
        }
        Console.WriteLine("The statement that your gender is female is {0}", isFemale);
    }
}
