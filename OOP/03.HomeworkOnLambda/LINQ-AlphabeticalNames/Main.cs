namespace AlphabeticalNames.LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class MainMethod
    {
        static void Main()
        {
            Student[] students = 
        {
            
            new Student("Zori", "Parvanova", 21),
            new Student("Panayot", "Ranchev", 30),
            new Student("Garo", "Michev", 41),
            new Student("Penyo", "Toptolev", 11),
            new Student("Niki", "Kunchev", 47),
            new Student("Muti", "Mongolev", 61),
            new Student("Nikoleri", "Bohinov", 27),
            new Student("Gubi", "Cvetkov", 23),
            new Student("Vasil", "Drumev", 18),            
        };
           
             
            // first name is alphabeticaly before last name
            List<Student> result = Student.CompareByName(students.ToList<Student>());
            
            foreach (var name in result)
	        {
		        Console.WriteLine(name);
	        }
            //separator
            Console.WriteLine(new string('=', 20));
            Console.WriteLine();

            //age is between 18 & 24 (inclusive)
            List<Student> arrangedbyage = Student.SortByAge(students.ToList<Student>());

            foreach (var st in arrangedbyage)
            {
                Console.WriteLine(st);
            }
            
            Console.WriteLine(new string('=', 20));
            Console.WriteLine();

            // Order by first and last name descending

            //lambda
            List<Student> names = Student.OrderByNameDescending(students.ToList<Student>());
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(new string('=', 20));
            Console.WriteLine();

            //linq
            List<Student> linqnames = Student.OrderByNameLinq(students.ToList<Student>());
            foreach (var name in linqnames)
            {
                Console.WriteLine(name);
            }

        }
    }
}
