using System;

class AlphabetNumbers
{
    static void Main(string[] args)
    {
        // Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.

        char[] letters = { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

        string word = Console.ReadLine();
        
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                if (word[i] == letters[j])
                {
                    Console.Write(j + " ");
                }
            }
        }
    }
}

