using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenceGame
{
    public class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        public int Health { get; private set; } = 2;

        public bool HasScored => (_pathStep >= _path.GetLength);

        public MapLocation Location => _path.GetLocation(_pathStep);

        public bool IsNeutralized => (Health <= 0);

        public bool IsActive => !(IsNeutralized || HasScored);
 
        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += 1;

        public void DecreaseHealth(int factor) => Health -= factor;

    }
}
