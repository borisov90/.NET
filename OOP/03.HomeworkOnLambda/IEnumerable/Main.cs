namespace IEnumerable
{
    using System;
    class MainMethod
    {
        static void Main()
        {
            int[] Test = { 1, 5, 10, 12, 7, 9 };

            Console.WriteLine(Test.Max());
            Console.WriteLine(Test.Min());
            Console.WriteLine(Test.Product());
            Console.WriteLine(Test.Average());
            Console.WriteLine(Test.Sum());

        }
    }
}
