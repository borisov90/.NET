using System;

class Program
{
    static void Main(string[] args)
    {
        int rounds = int.Parse(Console.ReadLine());
        int mScore = 0;
        int vScore = 0;
        for (int i = 0; i < rounds; i++)
        {
            string roundnumber = Console.ReadLine();
            roundnumber = roundnumber.TrimStart('-');
            roundnumber = roundnumber.TrimStart('0');
            for (int j = 0; j < roundnumber.Length; j++)
            {
                if (j < roundnumber.Length/2)
                {
                    mScore += (roundnumber[j] - '0');
                }
                else 
                {
                    vScore += (roundnumber[j] - '0');
                }
               
            }
            if (roundnumber.Length % 2 != 0)
            {
                mScore += roundnumber[(roundnumber.Length / 2)] - '0';
                //vScore += roundnumber[(roundnumber.Length / 2)] - '0';
            }
        }
        if (mScore > vScore)
        {
            Console.WriteLine("M {0}", mScore - vScore);
        }
        else if (mScore < vScore)
        {
            Console.WriteLine("V {0}", vScore - mScore);
        }
        else
        {
            Console.WriteLine("No {0}", mScore + vScore);
        }
    }
}

