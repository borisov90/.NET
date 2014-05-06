namespace Human
{
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Linq;
    class MainMethod
    {
        static void Main()
        {
            Student student1 = new Student("Mincho", "Praznikov", 2);
            Student student2 = new Student("Gosho", "Petkov", 3);
            Student student3 = new Student("Kiril", "Yordanov", 6);
            Student student4 = new Student("Encho", "Gospodinov", 5);
            Student student5 = new Student("Kolio", "Mamata", 4);
            Student student6 = new Student("Evstati", "Minkov", 3);
            Student student7 = new Student("Sancho", "Pansa", 2);
            Student student8 = new Student("Aleko", "Kalekov", 4);
            Student student9 = new Student("Minio", "Monev", 6);
            Student student10 = new Student("Chicho", "Gosho", 6);

            List<Student> students = new List<Student>{student1, student2, student3,
            student4, student5, student6, student7, student8, student9, student10};

            // order students by grade
            var orderByGrade = students.OrderBy(x => x.Grade).ThenBy(x => x.GetFirstName());
            foreach (var student in orderByGrade)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            Worker worker1 = new Worker("Pencho", "Penev", 202, 10);
            Worker worker2 = new Worker("Mincho", "Minchev", 403.10, 11);
            Worker worker3 = new Worker("Velcho", "Velchev", 508, 12);
            Worker worker4 = new Worker("Toma", "Borov", 101, 7);
            Worker worker5 = new Worker("Kosta", "Tsonev", 100.60, 7);
            Worker worker6 = new Worker("Rado", "Tsonev", 100, 14);
            Worker worker7 = new Worker("Borko", "Tsonev", 150, 5);
            Worker worker8 = new Worker("Jenio", "Miniov", 250, 5);
            Worker worker9 = new Worker("Potio", "Miohlev", 200, 13);
            Worker worker10 = new Worker("Aidi", "Molq", 200, 6);

            List<Worker> workers = new List<Worker>{worker1, worker2, worker3,
                worker4, worker5, worker6, worker7, worker8, worker9, worker10};

            // order workers by salary per hour
            var orderBySalaryPerHour = workers.OrderByDescending(x => x.PayPerHour());
            foreach (var worker in orderBySalaryPerHour)
            {
                Console.WriteLine(worker);
            }
            Console.WriteLine();

            // merge the two sequences and order by first and last name
            List<dynamic> merged = new List<dynamic>(students.Concat<dynamic>(workers));

            // make it with lambda
            var both =
                merged.OrderBy(x => x.GetFirstName()).ThenBy(x => x.GetLastName());

            foreach (var item in both)
            {
                Console.Write(item.GetFirstName());
                Console.WriteLine(" " + item.GetLastName());
            }
            Console.WriteLine();

        }
    }
}
