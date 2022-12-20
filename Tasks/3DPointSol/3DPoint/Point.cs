using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPoint
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point() { }
        public Point(int _x, int _y) 
        {
            X = _x; Y = _y; 
        }

        public static bool operator ==(Point Left, Point Right)
        {
            return(Left.X == Right.X && Left.Y == Right.Y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
