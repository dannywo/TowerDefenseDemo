using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Invader
    {
        private MapLocation _location;

        ////Getter
        //public MapLocation GetLocation()
        //{
        //    return _location;
        //}

        ////Setter
        //public void SetLocation(MapLocation value)
        //{
        //    _location = value;
        //}

        //Alternate way of writing get set
        public MapLocation Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }
    }
}