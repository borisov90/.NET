using System;

class GenVariationsWithRepeat
{
    static void Main()
    {
        //Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
        //N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

        int n = int.Parse(Console.ReadLine());
        int startNum = 1;
        int k = int.Parse(Console.ReadLine());

        int[] arr = new int[k];
        GenerateCombinations(arr, 0, startNum, n);
    }

    static void GenerateCombinations(int[] arr, int index, int startNum, int endNum)
    {
        if (index >= arr.Length)
        {
            // A combination was found 
            Console.WriteLine("{" + String.Join(", ", arr) + "}");
        }
        else
        {
            for (int i = startNum; i <= endNum; i++)
            {
                arr[index] = i;
                GenerateCombinations(arr, index + 1, i + 1, endNum);
            }
        }
    }
}

