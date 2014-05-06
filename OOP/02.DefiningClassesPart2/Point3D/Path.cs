//4 Create a class Path to hold a sequence of points in the 3D space. 

namespace PointThreeD
{
    using System.Collections.Generic;

    class Path
    {
        private List<Point3D> Points;
        
        public Path()
        {
            this.Points = new List<Point3D>();
        }
        public Path(params Point3D[] points) : this()
        {
            foreach (var item in points)
            {
                this.Points.Add(item);
            }
        }
      

        public void AddPoints(params Point3D[] points)
        {
            foreach (var item in points)
            {
                this.Points.Add(item);
            }
        }

        public IReadOnlyList<Point3D> ReadOnlyPoints
        {
            get { return Points.AsReadOnly(); }
        }
    }
}
