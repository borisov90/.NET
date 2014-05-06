namespace ExtensionMethods 
{
    using System;
    class MainMethod
    {
        static void Main()
        {
            string testString = Console.ReadLine();
            for (int i = 0; i < testString.Length; i++)
            {
                
                Console.WriteLine(testString.Substring(i, 1));
            }
        }
    }
}
