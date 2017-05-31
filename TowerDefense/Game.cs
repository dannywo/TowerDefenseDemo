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
                Path path = new Path(
                    new[] {
                        new MapLocation(0,2, map),
                        new MapLocation(1,2, map),
                        new MapLocation(2,2, map),
                        new MapLocation(3,2, map),
                        new MapLocation(4,2, map)
                        }
                );

                MapLocation location = path.GetLocation(8);
                if (location != null)
                {
                    Console.WriteLine($"{location.X} , {location.Y}");
                }
            }
            //MapLocation method will throw an error
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
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
