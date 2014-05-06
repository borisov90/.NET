namespace Human
{
    using System;
    public class Student : Human
    {
        //field

        private int grade;

        // property
        public int Grade
        {
            get { return this.grade; }
            set
            {
                if (value > 1 && value < 7)
                {
                    this.grade = value;
                }
                else
                {
                    throw new ArgumentException("Grades are between 2 and 6!");
                }
            }
        }
        // constructor

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        // methods
        
        public string GetFirstName()
        {
            return this.FirstName;
        }

        public string GetLastName()
        {
            return this.LastName;
        }

        public override string ToString()
        {
            return string.Format(" Student: {0} {1}. Grade: {2}.",
                GetFirstName(), GetLastName(), this.grade);
        }
    }
}
