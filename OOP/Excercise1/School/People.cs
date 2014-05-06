namespace School
{
    using System;
    public class People : IComment
    {
        private string name;
        private string comments;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The name you have entered is too short");
                }
                else
                {
                    this.name = value;
                }
            }
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
