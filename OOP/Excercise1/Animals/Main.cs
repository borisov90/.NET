namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    class MainMethod
    {
        static void Main()
        {
            try
            {
                Kitten testCat = new Kitten("pesho", "female", 10);
                Tomcat maleCat = new Tomcat("misho", "male", 5);
                Frog bigFrog = new Frog("gabcho", "male", 2);

                List<ISound> differentSounds = new List<ISound>();
                differentSounds.Add(testCat);
                differentSounds.Add(maleCat);
                differentSounds.Add(bigFrog);

                foreach (var item in differentSounds)
                {
                    item.MakeSound();
                }

                List<Animal> differentAnimalsList = new List<Animal>();
                differentAnimalsList.Add(new Kitten("kiryak", "female", 10));
                differentAnimalsList.Add(new Tomcat("gosho", "male", 4));
                differentAnimalsList.Add(new Frog("penio", "male", 2));
                differentAnimalsList.Add(new Frog("kondio", "male", 5));
                differentAnimalsList.Add(new Dog("sharo", "male", 2));
                differentAnimalsList.Add(new Kitten("pminka", "female", 8));

                //one query
                var animalGroups =
                    (from animal in differentAnimalsList
                     group animal by animal.GetType().Name into groups
                     select new
                     {
                         groupName = groups.Key,
                         averageSum =
                             (from anim in groups
                              select anim.Age).Average()
                     });

                foreach (var item in animalGroups)
                {
                    Console.WriteLine(item);
                }
                //several queries
                Console.WriteLine("Average kitten age: ");
                var result =
                    (from animal in differentAnimalsList
                     where animal.GetType() == typeof(Kitten)
                     select animal.Age).Average();
                Console.WriteLine(result);
                Console.WriteLine("Average tomcat age: ");
                result =
                    (from animal in differentAnimalsList
                     where animal.GetType() == typeof(Tomcat)
                     select animal.Age).Average();
                Console.WriteLine(result);
                Console.WriteLine("Average frog age: ");
                result =
                    (from animal in differentAnimalsList
                     where animal.GetType() == typeof(Frog)
                     select animal.Age).Average();
                Console.WriteLine(result);
                Console.WriteLine("Average dog age: ");
                result =
                    (from animal in differentAnimalsList
                     where animal.GetType() == typeof(Dog)
                     select animal.Age).Average();
                Console.WriteLine(result);


            }
            catch (ArgumentException err)
            {
                Console.WriteLine(err.Message);
            }
        
        }
    }
}
