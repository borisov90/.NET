namespace Human
{
    using System;

    class Worker : Human
    {
        //fields

        private double weeklypayment;
        private int HourPerDay;

        // Properties
        public double WeekSalary
        {
            get { return this.weeklypayment; }
            set
            {
                if (value > 0)
                {
                    this.weeklypayment = value;
                }
                else
                {
                    throw new ArgumentException("The week salary must be positive number!");
                }

            }
        }

        public int WorkHourPerDay
        {
            get { return this.HourPerDay; }
            set
            {
                if (value > 0 && value < 15)
                {
                    this.HourPerDay = value;
                }
                else
                {
                    throw new ArgumentException("The work hours must be between 1 and 14 including!");
                }
            }
        }

        // constructor
        public Worker(string firstName, string lastName, double weekSalary, int workHourPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHourPerDay = workHourPerDay;
        }


        //methods

        public double PayPerHour()
        {
            return this.weeklypayment / (this.HourPerDay * 5);
        }

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
            return string.Format("Worker: {0} {1}. Salary: {2:F2}.",
                GetFirstName(), GetLastName(), PayPerHour());
        }
    }
}

