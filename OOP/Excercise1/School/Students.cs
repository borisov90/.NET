namespace School
{
    using System;
    public class Student : People
    {
        //field
        private int uniqueNumber; 

        //property
        public int UniqueNumber
        {
            get { return this.uniqueNumber; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentNullException("Student's unique number cannot be zero or negative");
                }
                else
                {
                    this.uniqueNumber = value;
                }
            }
        }
        //constructor
        public Student(string name, int uniquenumber)
        {
            this.Name = name;
            this.uniqueNumber = uniquenumber;
        }
    }
}
