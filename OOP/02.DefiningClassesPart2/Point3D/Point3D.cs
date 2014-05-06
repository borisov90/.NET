//01 Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space. Implement the ToString() to enable printing a 3D point. 
//Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. 
 
//02 Add a static property to return the point O.
namespace PointThreeD
{
    
    public struct Point3D
    {
        public double x {get; set;}
        public double y {get; set;}
        public double z {get; set;}

        public Point3D(double x, double y, double z) : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        

        private static readonly Point3D theOPoint = new Point3D(0, 0, 0);

        public static Point3D Center
        {
            get { return theOPoint; }
        }
        
        
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", x, y, z);
            
        }

    }
}
