namespace Integers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    class Devisability
    {
        // 06 Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
        
        // with Linq
        public static int[] Devisable( int[] numbers)
        {
            var devisablenumbers =
                from numb in numbers
                where numb % 7 == 0 && numb % 3 == 0
                select numb;

            return devisablenumbers.ToArray<int>();
        }

        //with Lambda
        public static int[] DevisableWithLambda(int[] numbers)
        {
            var devisable =
                numbers.Where(x => (x % 7 == 0 && x % 3 == 0));
                
            return devisable.ToArray<int>();
        }
    }
}
