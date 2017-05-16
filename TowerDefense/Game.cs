using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Game
    {
        static void Main()
        {
            Tower tower = new Tower();
            Map map = new Map(8, 5);

            try
            {
                MapLocation maplocation = new MapLocation(20, 20, map);
            }
            catch (Exception)
            {
                Console.WriteLine("That map location is not on the map!");
            }


            //int area = map.Width * map.Height;

            //MapLocation x = new MapLocation(4, 2);

            //Point p = x;

            //map.OnMap(new MapLocation(0, 0));

            //bool isOnMap = map.OnMap(x);
            //Console.WriteLine(isOnMap); // return true

            ////point = new Point(8, 5);
            ////isOnMap = map.OnMap(point); // returns false
            ////Console.WriteLine(isOnMap);



            //Console.WriteLine(x.DistanceTo(5, 5));
            Console.ReadKey();
        }
    }
}
