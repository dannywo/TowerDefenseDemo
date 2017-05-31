using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    // inherits System.Exception
    class TowerDefenseException : Exception
    {
        public TowerDefenseException()
        {

        }

        //system.exception has a base class constructor that takes a string
        public TowerDefenseException(string message) : base(message)
        {

        }
    }

    //Sub inheretence - 3rd level of inheretence
    class OutOfBoundsException : TowerDefenseException
    {
        public OutOfBoundsException()
        {

        }

        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
