using System;

namespace DefenseGame
{
    class Point
    {
        public readonly int X;
        public readonly int Y;
        
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        // This calculates the distance between the Point object (the DistanceTo Method is being called on)
        // and the X and Y coordinates being passed in.
        public int DistanceTo(int x, int y)
        {
            return (int)Math.Sqrt(Math.Pow(X-x, 2) + Math.Pow(Y-y, 2));
        }
        
        // This calculates the distance between the two Point objects
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}