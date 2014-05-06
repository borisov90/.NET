/* 07
 * Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the
 * GenericList<T>. You may need to add a generic constraints for the type T.*/

namespace Generics
{
    using System;
    public static class GenericListExtentions
    {
        public static T Min<T>(this GenericList<T> list) where T : IComparable<T>
        {
            T min = list.Peek(0);
            for (int i = 1; i < list.Count(); i++)
            {
                if (list.Peek(i).CompareTo(min) < 0)
                {
                    min = list.Peek(i);
                }
            }
            return min;
        }

        public static T Max<T>(this GenericList<T> list) where T : IComparable<T>
        {
            T max = list.Peek(0);
            for (int i = 1; i < list.Count(); i++)
            {
                if (list.Peek(i).CompareTo(max) > 0)
                {
                    max = list.Peek(i);
                }
            }
            return max;
        }
    }
}
