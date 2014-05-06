using System;

class SequenceOfGivenSum
{
    static void Main(string[] args)
    {
        //Write a program that finds in given array of integers a sequence of given sum S (if present).
        //Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

        Console.WriteLine("Enter length: "); // the numbers in the array
        int length = int.Parse(Console.ReadLine());
        int[] elements = new int[length];

        Console.WriteLine("Enter sum: "); // the sum
        int S = int.Parse(Console.ReadLine());
        int tempsum = 0;
        int tempstart = 0;
        int start = 0;
        int end = 0;
        bool available = false;

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("Enter array number {0}:", i); // entering the numbers in the array
            elements[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < elements.Length; i++)
        {
            tempstart = i;
            tempsum = 0;

            for (int j = i; j < elements.Length; j++) // checks if the current sum (tempsum) is equal to the required sum (S);
            {
                if (tempsum == S) //first case scenario - the current sum is equal
	            {
                    start = tempstart;
                    end = j;
                    available = true;
                    break;
	            }
                else if (tempsum < S) // second case - the current sum is lower than the required
                {
                    tempsum += elements[j];
                    if (tempsum > S) // checks if when the element was added the current sum became more than the required
                    {
                        tempsum = 0;
                        tempstart = j - 1;
                        tempsum = elements[j] + elements[j - 1]; // if yes - it sets the current sum to be equal to the current element added to the element before him (element[j-1]); This is private case of the third case scenario.
                        if (tempsum == S) // if the sum of those two is equal to S - break;
                        {
                            end = j+1;
                            start = tempstart;
                            available = true;
                            break;
                        }
                    }
                }
                else if (tempsum > S) // third case scenario. the current sum is bigger than the desired one. 
                {
                    tempsum = 0;
                    tempstart = j - 1;
                    tempsum = elements[j] + elements[j-1];
                    if (tempsum == S)
                    {
                        end = j;
                        start = tempstart;
                        available = true;
                        break;
                    }
                }
            }
            if (available)
            {
                break;
            }
        }
        if (available)
        {
            for (int i = start; i < end; i++) // prints the elements from position 'start' to position 'end'.
            {
                Console.Write(elements[i] + " ");
            } 
        }
        else // used if bool available == false;
        {
            Console.WriteLine("No subset available with this sum");
        }
    }
}

