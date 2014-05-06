using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_19.GroupStudents
{
    class GroupStudents
    {
       
        /// 18.Create a program that extracts all students grouped by GroupName and then prints them to the console. Use LINQ.
        
        static void GroupByGroupNameWithLinq()
        {
            var studentsGroupedByGroupNameWithLinq =
                from student in students
                group student by student.GroupName into newGroup
                orderby newGroup.Key
                select newGroup;

            foreach (var currentGroup in studentsGroupedByGroupNameWithLinq)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(currentGroup.Key);
                Console.ResetColor();

                foreach (var student in currentGroup)
                {
                    Console.WriteLine(student.FullName);
                }
                Console.WriteLine();
            }
        }

        
        /// 19.Rewrite the previous using extension methods.
        
        static void GroupByGroupNameWithLambda()
        {
            var studentsGroupedByGroupNameWithLambda = students.GroupBy(x => x.GroupName).OrderBy(x => x.Key);

            foreach (var currentGroup in studentsGroupedByGroupNameWithLambda)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(currentGroup.Key);
                Console.ResetColor();

                foreach (var student in currentGroup)
                {
                    Console.WriteLine(student.FullName);
                }
                Console.WriteLine();
            }
        }

        static Student[] students;
        static void Main()
        {
            students = new Student[]
            {
                new Student("Plamen Krumov", "Right Back"),
                new Student("Daniel Dimov", "Center Back"),
                new Student("Plamen Dimov", "Center Back"),
                new Student("Stanislav Angelov", "Center Back"),
                new Student("Aymen Bellaid", "Left Back"),
                new Student("Miki Orachev", "Left back")
            };

            GroupByGroupNameWithLinq();

            GroupByGroupNameWithLambda();
        }
    }
}