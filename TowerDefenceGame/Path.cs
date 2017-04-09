using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenceGame
{
    public class Path
    {
        private readonly MapLocation[] _path;

        public int GetLength => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocation(int pathStep)
        {
            return (pathStep < _path.Length) ? _path[pathStep] : null;
        }

        public bool OnPath(MapLocation point)
        {
            foreach (Point p in _path)
            {
                if (p._y == point._y)
                    return true;
            }
            return false;
        }
    }
}
