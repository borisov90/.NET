//using System;
//using System.Collections.Generic;

//class Program
//{
   
//    static void Quicksort(int[] array)
//    {
//        if (array.Length < 2)
//        {
//            Print(array);
//        }
//        else
//        {
//            int pivot = (array.Length) / 2;
//            int[] smallerArray = new int[array.Length / 2];
//            int[] biggerarray = new int[array.Length - (array.Length/2)];

//            for (int i = 0; i < array.Length-1; i++)
//            {
//                if (array[i] < pivot)
//                {
//                    smallerArray[i] = array[i];
//                }
//                else
//                {
//                    biggerarray[i] = array[i];
//                }
//            }
//            Quicksort(smallerArray);
//            Quicksort(biggerarray);
//        }
//    }
  
//    static void Main(string[] args)
//    {
//        int length = int.Parse(Console.ReadLine());
//        int[] Array = new int[length];
        

//        Quicksort(Array);
//    }
//}


