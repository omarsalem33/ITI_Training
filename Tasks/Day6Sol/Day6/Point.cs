using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{

 
    internal class Point
    {
        private int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //public override string ToString()
        //{
        //    return String.Format("([{X}] {Y}})", x, y);
        //}

        public int X { get; }
        public int Y { get; }

        public static bool operator== (Point p1, Point p2)
        {
            return ((p1.x == p2.x) && (p1.y == p2.y));
        }
        public static bool operator!= (Point p1, Point p2)
        {
            return !(p1 == p2);
        }
    }
}




