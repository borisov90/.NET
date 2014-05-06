namespace School
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    public class Teacher : People, IEnumerable
    {
        
        ///fields

        private List<Disciplines> setofdisciplines;

        // constructors

        public Teacher(string name,  params Disciplines[] teacheddisciplines) 
        {
            this.Name = name;
            this.setofdisciplines = new List<Disciplines>(teacheddisciplines);
        }

        //property

        public List<Disciplines> Disciplines
        {
            get { return new List<Disciplines>(this.setofdisciplines); }
            
        }

        //method 

        //public void AddDiscipline(Disciplines newdiscipline)
        //{
        //    this.setofdisciplines.Add(newdiscipline);
        //}

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
        

    }
}
