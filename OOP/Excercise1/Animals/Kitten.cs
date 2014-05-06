namespace Animals
{
    using System;
    class Kitten : Cat, ISound
    {
        public Kitten(string name, string gender, int age) : base( name, gender, age)
        {
            if (gender != "female")
            {
                throw new ArgumentException("Kittens are pussies (female)");
            }
        }
        
        public void MakeSound()
        {
            Console.WriteLine("miau");
        }
    }
}
