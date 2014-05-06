namespace School
{
    using System;
    //
    using System.Collections.Generic;
    using System.Collections;
    public class Class : IEnumerable, IComment
    {
        //fields
        private string uniqueTextIdentifier;
        private List<Teacher> teachers;
        private List<Student> students;
        private string comments;

        //constructor
        public Class(string identifier)
        {
            
            this.uniqueTextIdentifier = identifier;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        //properties
        public string UniqueID
        {
            get { return this.uniqueTextIdentifier; }
        }
        
        public List<Teacher> Teachers
        {
            get { return this.teachers; }
        }
        public List<Student> Students
        {
            get { return this.students; }
        }

        //methods

        public void AddStudent(string name, int uniquenumber)
        {
            this.students.Add(new Student(name, uniquenumber));
        }
        public void AddTeacher(string name, Disciplines discipline)
        {
            this.teachers.Add(new Teacher(name, discipline));
        }

        public string Comments
        {
            get
            {
                if (this.comments == null)
                {
                    return "No comments yet";
                }
                return this.comments;
            }
            set
            {
                this.comments = value;
            }
        }


        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        
    }
}
