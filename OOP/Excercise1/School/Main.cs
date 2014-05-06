namespace School
{
    using System;
    using System.Collections.Generic;
    class MainMethod
    {
        static void Main()
        {
            Disciplines first = new Disciplines();
            first.Name = "Philosophy";
            Disciplines second = new Disciplines();
            second.Name = "Biology";
            Disciplines third = new Disciplines();
            third.Name = "Math";
            // Console.WriteLine(Philosophy.Name);
            List<Disciplines> disciplines = new List<Disciplines>();
            disciplines.Add(first);
            disciplines.Add(second);
            disciplines.Add(third);

            Console.WriteLine("The disciplines in the school are: ");

            Console.WriteLine();

            foreach (var discipline in disciplines)
            {
                Console.WriteLine(discipline);
            }

            Console.WriteLine();

            Class firstclass = new Class("1B");

            firstclass.AddStudent("Mincho", 19);
            firstclass.AddStudent("Gencho", 5);
            firstclass.AddStudent("Pencho", 10);
            firstclass.AddStudent("Vencho", 3);
            firstclass.AddStudent("Nencho", 18);

            firstclass.AddTeacher("Minka Mincheva", first);
            firstclass.AddTeacher("Penka Pencheva", second);
            firstclass.AddTeacher("Ginka Gincheva", third);

            Console.WriteLine("These are the students in first grade");

            Console.WriteLine();

            foreach (var students in firstclass.Students)
            {
                Console.WriteLine(students.Name + " with id number: " + students.UniqueNumber);
                Console.WriteLine();
            }
           
            Console.WriteLine("And these are their teachers: ");

            Console.WriteLine();

            foreach (var teachers in firstclass.Teachers)
            {
                Console.Write(teachers.Name + " and she is a teacher in ");
                foreach (var subject in teachers.Disciplines)
                {
                    Console.Write(subject);
                    
                }
                Console.WriteLine();
                Console.WriteLine();
            }


            Console.WriteLine();
        }
    }
}
