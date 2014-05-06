//03. Write a static class with a static method to calculate the distance between two points in the 3D space


namespace PointThreeD
{
    using System;

    static class Distance
    {
        private static double deltaX;
        private static double deltaY;
        private static double deltaZ;

        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            deltaX = firstPoint.x - secondPoint.x;
            deltaY = firstPoint.y - secondPoint.y;
            deltaZ = firstPoint.z - secondPoint.z;

            return Math.Sqrt((deltaX * deltaZ) + (deltaY * deltaY) + (deltaZ * deltaZ));
        }
    }
}
