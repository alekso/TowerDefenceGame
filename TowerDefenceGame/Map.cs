using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenceGame
{
    public class Map
    {
        public readonly int _width;
        public readonly int _height;

        public Map(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public bool OnMap(Point point)
        {
            return point._x>=0 && point._x <= _width && 
                point._y >=0 && point._y <= _height;
        }
    }
}
