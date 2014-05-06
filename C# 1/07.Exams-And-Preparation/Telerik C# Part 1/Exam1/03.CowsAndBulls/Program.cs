using System;

class Program
{
    static void Main(string[] args)
    {
        int secretnumber = int.Parse(Console.ReadLine());
        int expectedbulls = int.Parse(Console.ReadLine());
        int expectedcows = int.Parse(Console.ReadLine());
        int[] secretnumbers = new int[4];
        
        if (expectedbulls + expectedcows <= 4)
        {
            int countsolution = 0;

            for (int i = 1111; i <= 9999; i++)
            {

                int countbulls = 0;
                int countcows = 0;
                //the first number's digits
                int firstdigit = secretnumber / 1000;
                int seconddigit = (secretnumber / 100) % 10;
                int thirddigit = (secretnumber / 10) % 10;
                int fourthdigit = (secretnumber % 10);
                //the digits of the guessed number;

                int one = i / 1000;
                int two = (i / 100) % 10;
                int three = (i / 10) % 10;
                int four = (i % 10);
                if (two == 0 || three == 0 || four == 0)
                {
                    continue;
                }
                if (one == firstdigit)
                {
                    countbulls++;
                    one = 0;
                    firstdigit = -1;
                }
                if (two == seconddigit)
                {
                    countbulls++;
                    two = 0;
                    seconddigit = -1;
                }
                if (three == thirddigit)
                {
                    countbulls++;
                    three = 0;
                    thirddigit = -1;
                }
                if (four == fourthdigit)
                {
                    countbulls++;
                    four = 0;
                    fourthdigit = -1;
                }
                if (one == seconddigit)
                {
                    countcows++;
                    one = 0;
                    seconddigit = -1;
                }
                else if (one == thirddigit)
                {
                    countcows++;
                    one = 0;
                    thirddigit = -1;
                }
                else if (one == fourthdigit)
                {
                    countcows++;
                    one = 0;
                    fourthdigit = -1;
                }
                if (two == firstdigit)
                {
                    countcows++;
                    two = 0;
                    firstdigit = -1;
                }
                else if (two == thirddigit)
                {
                    countcows++;
                    two = 0;
                    thirddigit = -1;
                }
                else if (two == fourthdigit)
                {
                    countcows++;
                    two = 0;
                    fourthdigit = -1;
                }
                if (three == firstdigit)
                {
                    countcows++;
                    three = 0;
                    firstdigit = -1;
                }
                else if (three == seconddigit)
                {
                    countcows++;
                    three = 0;
                    seconddigit = -1;
                }
                else if (three == fourthdigit)
                {
                    countcows++;
                    three = 0;
                    fourthdigit = -1;
                }
                if (four == firstdigit)
                {
                    countcows++;
                    four = 0;
                    firstdigit = -1;
                }
                else if (four == seconddigit)
                {
                    countcows++;
                    four = 0;
                    seconddigit = -1;
                }
                else if (four == thirddigit)
                {
                    countcows++;
                    four = 0;
                    thirddigit = -1;
                }
                if (countbulls == expectedbulls && countcows == expectedcows)
                {
                    Console.Write(i + " ");
                    countsolution++;
                }
            }
            if (countsolution == 0)
            {
                Console.Write("No");
            }
        }
        else
        {
            Console.Write("No");
        }
    }
}

