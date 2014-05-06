namespace PointThreeD
{
    using System;
    using System.Collections.Generic;

    class MainClass
    {
        static void Main()
        {
            Point3D first = new Point3D(1, 3, 5);
            Point3D second = new Point3D(-5, -10, -15);
            Path test = new Path(first, second);
            Point3D third = new Point3D(5, 6, 7);
            test.AddPoints(third);
            PathStorage.SavePath(test);
            List<Path> list = new List<Path>();
            string loc = @"..\..\paths.txt";
            list = PathStorage.LoadPath(loc);
            foreach (Path path in list)
            {
                foreach (Point3D point in path.ReadOnlyPoints)
                {
                    Console.WriteLine(point);
                }
            }
        }
    }
}
