using System;

class CompareCharactersLexicography
{
    static void Main(string[] args)
    {
       // Write a program that compares two char arrays lexicographically (letter by letter).
        Console.WriteLine("Enter first char array (or string): ");
        string firststring = Console.ReadLine();

        Console.WriteLine("Enter second char array (or string): ");
        string secondstring = Console.ReadLine();

        char[] firstchararray = firststring.ToCharArray();
        char[] secondchararray = secondstring.ToCharArray();

        int firststringlength = firstchararray.Length;
        int secondstringlength = secondchararray.Length;

        int minLength = Math.Min(firststringlength, secondstringlength);
        bool isEqual = true;

        for (int i = 0; i < minLength; i++)
        {
            if (firstchararray[i] != secondchararray[i])
            {
                isEqual = false;
                if ((firstchararray[i] < secondchararray[i]) && isEqual == false)
                {
                    Console.WriteLine("The first char array is lexicographically before the second one");
                }
                else if ((firstchararray[i] > secondchararray[i]) && isEqual == false)
                {
                    Console.WriteLine("The second char array is lexicographically before the first one");
                }
                break;
            }
        }
       
        if ((isEqual == true) && (firststringlength == secondstringlength))
        {
            Console.WriteLine("The two char arrays are lexicographically the same");
        }
        else if ((isEqual == true) && (firststringlength < secondstringlength))
        {
            Console.WriteLine("The first char array is lexicographically before the second one");
        }
        else if ((isEqual == true) && (firststringlength > secondstringlength))
        {
            Console.WriteLine("The second char array is lexicographically before the first one");
        }
    }
}

