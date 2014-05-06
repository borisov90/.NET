namespace AlphabeticalNames.LINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {

        public decimal Age { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Student(string namefirst, string namelast, decimal age)
        { 
            this.Age = age;
            this.FirstName = namefirst;
            this.LastName = namelast;
        }
        // 03 Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. Use LINQ query operators.
        public static List<Student> CompareByName(List<Student>students)
        {
            
                var sorted =
                from st in students
                where st.FirstName.CompareTo(st.LastName) < 0
                select st;

            return sorted.ToList<Student>();
        }
        // 04 Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

        public static List<Student> SortByAge(List<Student> students)
        {
            var sorted =
                from st in students
                where st.Age >= 18 && st.Age <= 24
                select st;

            return sorted.ToList<Student>();
                
        }
        // 05. Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in descending order. Rewrite the same with LINQ.

        //Lambda
        public static List<Student> OrderByNameDescending(List<Student> students)
        {
            var sorted = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);

            return sorted.ToList<Student>();

        }

        // Linq
        public static List<Student> OrderByNameLinq(List<Student> students)
        {
            var sorted =
                from st in students
                orderby st.FirstName descending, st.LastName descending
                select st;

            return sorted.ToList<Student>();
                
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, {2}", FirstName, LastName, Age);
        }
   
    }
}
