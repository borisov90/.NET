namespace Animals
{
    using System;
    class Frog : Animal, ISound
    {
        public Frog(string name, string gender, int age) : base( name, gender, age)
        {

        }
        public void MakeSound()
        {
            Console.WriteLine("quaback");
        }
    }
}
