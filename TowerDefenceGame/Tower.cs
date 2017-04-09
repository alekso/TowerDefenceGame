using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenceGame
{
    public class Tower
    {
        private readonly MapLocation _location;

        private const int _fireRange = 1;
        private const int _power= 1;
        private const double _accuracy = 0.75;

        private static readonly Random _random = new Random();

        public Tower(MapLocation location, Path path)
        {
            

            if (path.OnPath(location))
            {
                throw new OutOfBoundException("You cant put tower on this point");
            }

            _location = location;

        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _fireRange))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("Shot at and hit an invader!");

                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Invader is neutrolized!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ooops, miss!");
                    }

                    break;
                }
            }
        }
    }
}
