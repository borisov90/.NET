namespace Animals
{
    using System;
    class Tomcat : Cat,  ISound
    {
         public Tomcat(string name, string gender, int age) : base( name, gender, age)
        {
            if (gender != "male")
            {
                throw new ArgumentException("Kittens are pussies (female)");
            }
        }
        
        public void MakeSound()
        {
            Console.WriteLine("miooooooooooooooooooooooooooooooiu");
        }
    }
}
