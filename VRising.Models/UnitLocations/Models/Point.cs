

using System;

namespace VRising.Models.UnitLocations.Models
{
    public class Point
    {
        public float X { get; }
        public float Y { get; }
        public string Name { get; set; }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }

        public double Distance(Point other)
        {
            return Math.Sqrt(Math.Pow((X - other.X), 2) + Math.Pow((Y - other.Y), 2));
        }

    }
}
