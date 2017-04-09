using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenceGame
{
    public class TowerDefenceException : Exception
    {
        public TowerDefenceException()
        {

        }

        public TowerDefenceException(string message) : base(message)
        {

        }
    }

    public class OutOfBoundException : TowerDefenceException
    {
        public OutOfBoundException()
        {

        }
        public OutOfBoundException(string message) : base(message)
        {

        }
    }
}
