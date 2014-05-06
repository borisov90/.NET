namespace Animals
{
    using System;

    class Animal 
    {
        //fields
        private string name;
        private string gender;
        private int age;

        //properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
            }
        }

        public string Gender
        {
            get { return this.gender; }
            set 
            {
                if (value == string.Empty)
                {
                    throw new ArgumentException("Enter gender please");
                }
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age can't be a negative number");
                }
            }
        }

        // constructor

        public Animal(string Name, string Gender, int Age)
        {
            this.age = Age;
            this.gender = Gender;
            this.name = Name;
        }
    }
}
