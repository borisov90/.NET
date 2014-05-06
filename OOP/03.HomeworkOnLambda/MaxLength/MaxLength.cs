namespace MaxLength
{
    using System;
    
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class StringMaximumLength
    {
        //17. Write a program to return the string with maximum length from an array of strings. Use LINQ.
        static void Main()
        {
            // you can test with this

            //string[] stringSequence = new string[]
            //{
            // "The match is about to start",
            // "Gerrard passes to Suarez",
            // "The striker looks forward",
            // "He dribbles the ball",
            // "Long pass for Sturridge",
            // "He's in front of the goalkeeper now. Here's a chance. Could this be a goal.. He scores",

            //};

            Console.Write("Enter string sequence length: ");
            int length = int.Parse(Console.ReadLine());

            string[] stringSequence = new string[length];
            for (int i = 0; i < length; i++)
            {
                stringSequence[i] = Console.ReadLine();
            }

            //sort strings by length in descending order and then get the first one.
            //var stringWithMaximalLength = stringSequence.OrderByDescending(x => x.Length).First();

            var stringWithMaximalLength = stringSequence.Aggregate((max, current) => max.Length > current.Length ? max : current);

            Console.WriteLine(stringWithMaximalLength);

        }
    }
}
