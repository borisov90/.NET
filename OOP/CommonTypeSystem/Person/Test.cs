namespace Person
{
    using System;
    using System.Collections.Generic;
   
    public class PersonTest
    {
        static void Main()
        {
            List<Person> peopleToTest = new List<Person>();
            peopleToTest.Add(new Person("Minka", 5));
            peopleToTest.Add(new Person("Kuncho", null));
            peopleToTest.Add(new Person("Spas", 99));
            peopleToTest.Add(new Person("Kiro"));

            foreach (var person in peopleToTest)
            {
                Console.WriteLine(person);
            }
        }
    }
}