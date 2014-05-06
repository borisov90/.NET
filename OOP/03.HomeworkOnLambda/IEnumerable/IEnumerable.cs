namespace IEnumerable
{
    using System;
    using System.Collections.Generic;
    
 

    // 02 Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
    
    public static class IEnumerable
    {
        public static int Sum<T>(this IEnumerable<T> nmbrs) where T : IComparable
        {
            var sum = 0;

            foreach (var nmbr in nmbrs)
            {
                sum += (dynamic)nmbr;
            }
    // мъчих се да измисля към какво да го кастна, но не успях да измисля по-добро решение, затова погледнах във форума и там ми изскочи този dynamic
            return sum;
            
        }
        public static int Min<T>(this IEnumerable<T> nmbrs) where T : IComparable
        {
            dynamic min = int.MaxValue;

            foreach (var nmbr in nmbrs)
            {
                if (nmbr < min)
                    min = nmbr;
            }
           
            return min;
        }

        public static int Max<T>(this IEnumerable<T> nmbrs) where T : IComparable
        {
            dynamic max = int.MinValue;

            foreach (var nmbr in nmbrs)
            {
                if (nmbr > max)
                    max = nmbr;
            }

            return max;
        }

        public static int Product<T>(this IEnumerable<T> nmbrs) where T : IComparable
        {
            dynamic product = 1;

            foreach (var nmbr in nmbrs)
            {
                product *= nmbr;
            }

            return product;
        }
        public static int Average<T>(this IEnumerable<T> nmbrs) where T : IComparable
        {
            dynamic sum = 0;
            int count = 0;

            foreach (var nmbr in nmbrs)
            {
                sum += (dynamic)nmbr;
                count++;
            }

            return sum / count;
        }
    }
}
