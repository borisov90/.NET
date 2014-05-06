// 04. Create a static class PathStorage with static methods to save and
// load paths from a text file. Use a file format of your choice. */

namespace PointThreeD
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class PathStorage
    {
        private const int NUMBER_OF_POINTS_STORED = 3;

        public static void SavePath(Path currentPath)
        {
            using (StreamWriter sw = new StreamWriter(@"..\..\paths.txt", true))
            {
                sw.Write(string.Join(",", currentPath.ReadOnlyPoints));
                sw.WriteLine();
            }
        }
        public static List<Path> LoadPath(string fileLocation)
        {
            List<Path> paths = new List<Path>();
            using (StreamReader sr = new StreamReader(fileLocation))
            {
                string currentLine = sr.ReadLine();
                while (currentLine != null)
                {
                    string[] points = currentLine.Split(new char[] { ' ', ',', '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                    Path currentPath = new Path();
                    for (int i = 0; i < points.Length; i += 3)
                    {
                        double currentPointX = double.Parse(points[i]);
                        double currentPointY = double.Parse(points[i + 1]);
                        double currentPointZ = double.Parse(points[i + 2]);
                        Point3D currentPoint = new Point3D(currentPointX, currentPointY, currentPointZ);
                        currentPath.AddPoints(currentPoint);
                    }
                    paths.Add(currentPath);
                    currentLine = sr.ReadLine();
                }
            }
            return paths;
        }
    }
}