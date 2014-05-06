namespace Animals
{
    using System;
    class Dog : Animal, ISound
    {
        public Dog(string name, string gender, int age) : base( name, gender, age)
        {

        }
        public void MakeSound()
        {
            Console.WriteLine("bao bao");
        }
    }
}
