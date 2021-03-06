﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        //Using Cartesian distance formula
        public double DistanceTo(int x, int y)
        {
            //int xDiff = X - x;
            //int yDiff = Y - y;

            //int xDiffSquared = xDiff * xDiff;
            //int yDiffSquared = yDiff * yDiff;

            //var result = Math.Round(Math.Sqrt(xDiffSquared + yDiffSquared));
            //return result;

             return (int)Math.Sqrt(Math.Pow(X-x, 2) + Math.Pow(Y-y, 2));
        }
    }
}
