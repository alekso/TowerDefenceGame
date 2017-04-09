using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenceGame
{
    public class Point : IEquatable<Point>
    {
        public readonly int _x;
        public readonly int _y;

        public Point (int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int DistanceTo(int x, int y)
        {
            return (int)Math.Sqrt(Math.Pow(x - _x, 2) + Math.Pow(y - _y, 2));
        }

        public int DistanceTo(Point point)
        {
            return DistanceTo(point._x, point._y);
        }

        public bool Equals(Point other)
        {
            if (other == null) return false;

            return _y == other._y;
        }
    }
}
