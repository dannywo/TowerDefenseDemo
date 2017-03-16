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

            int area = map.Width * map.Height;

            Point point = new Point(4, 2);
            bool isOnMap = map.OnMap(point);
            Console.WriteLine(isOnMap); // return true

            point = new Point(8, 5);
            isOnMap = map.OnMap(point); // returns false
            Console.WriteLine(isOnMap);
            Console.ReadKey();
        }
    }
}
