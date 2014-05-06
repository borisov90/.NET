namespace School
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public class Disciplines : IEnumerable, IComment
    {
        // I use IEnumerable so I would be able to foreach the disciplines

        //fields
        private string name;
        private int numberOflectures;
        private int numberOfExcercises;
        private string comments;

        //properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Wrong discipline name");
                }
                this.name = value;
            }
        }
        public int NumberOfLectures
        {
            get { return this.numberOflectures; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The discipline is left without any lectures");
                }
                this.numberOflectures = value;
            }
        }

        public int NumberOfExcercises
        {
            get { return this.numberOfExcercises; }
            set
            {
                if (this.numberOfExcercises < 1)
                {
                    throw new ArgumentException("The class is left without any excercises");
                }
                this.numberOfExcercises = value;
            }
        }

        //public static Disciplines(string name, int numberoflectures, int numberofexercises) 
        //{

        //}

        public IEnumerator GetEnumerator() // foreach
        {
            throw new NotImplementedException();
        }
        public override string ToString() //to print the foreach
        {
            return string.Format(this.name);
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
    }
}
