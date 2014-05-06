namespace Human
{
    using System;
    using System.Collections.Generic;
    
    public abstract class Human
    {
        // fields

        private readonly string firstName;
        private readonly string lastName;

        //getter properties

        protected string FirstName
        {
            get { return this.firstName; }
        }

        protected string LastName
        {
            get { return this.lastName; }
        }

        //something like aconstructor for the abstract class to be used by the child classess

        protected Human(string firstName, string lastName)
        {
            if (firstName.Length > 2)
            {
                this.firstName = firstName;
            }
            else
            {
                throw new ArgumentException("The first name was too short");
            }

            if (lastName.Length > 2)
            {
                this.lastName = lastName;
            }
            else
            {
                throw new ArgumentException("The last name was too short");
            }
        }
    }
}