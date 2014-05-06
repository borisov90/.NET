namespace SubstringExtensionMethod
{
    // Test for the Substring Extension Method
    using System;
    using System.Text;
    class MainMethod
    {
        static void Main(string[] args)
        {
            StringBuilder testString =  new StringBuilder();
            Console.WriteLine("Enter sentence or a word for the StringBuilder to use, please: ");
            testString.Append(Console.ReadLine());
            int startPosition = 0;
            int posLength = 1;

            Console.WriteLine();
            Console.WriteLine("This is how the stringbuilder breaks the text you have entered into substrings: ");
            Console.WriteLine();

            for (int i = 0; i < testString.Length; i++)
            {
               
                Console.WriteLine("Letter {0}, is substring number {1}",testString.Substring(startPosition + i, posLength), i);
            }
        }
    }
}
