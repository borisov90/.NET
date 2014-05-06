namespace Integers
{
    using System;
    
    class MainMethod
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 42, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27 };

            foreach (var item in Devisability.Devisable(numbers))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('*', 5 ));
            foreach (var item in Devisability.DevisableWithLambda(numbers))
            {
                Console.WriteLine(item);
            }
        }
    }
}
