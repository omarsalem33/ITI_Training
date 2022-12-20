using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPoint
{
    internal class Complex
    {
        public Complex()
        {
            Real = Imagine = 0;

        }
        public Complex(int _Real, int _Imagine)
        {
            Real = _Real;
            Imagine = _Imagine;
        }
        public int Real { get; set; }
        public int Imagine { get; set; }


        public static Complex operator +(Complex Left, Complex Right)
        {
            Complex temp = new Complex();
            temp.Real = Left.Real + Right.Real;
            temp.Imagine = Left.Imagine + Right.Imagine;
            return temp;
        }

        public static Complex operator -(Complex Left, Complex Right)
        {
            Complex temp = new Complex();
            temp.Real = Left.Real - Right.Real;
            temp.Imagine = Left.Imagine - Right.Imagine;
            return temp;
        }

        public static bool operator >(Complex Left, Complex Right)
        {
            if (Left.Real > Right.Real)
                if (Left.Imagine > Right.Imagine)
                    return true;
            return false;
        }

        public static bool operator <(Complex Left, Complex Right)
        {
            if (Left.Real < Right.Real)
                if (Left.Imagine < Right.Imagine)
                    return true;
            return false;
        }

        public static bool operator >=(Complex Left, Complex Right)
        {
            if (Left.Real >= Right.Real)
                if (Left.Imagine >= Right.Imagine)
                    return true;
            return false;
        }
        public static bool operator <=(Complex Left, Complex Right)
        {
            if (Left.Real <= Right.Real)
                if (Left.Imagine <= Right.Imagine)
                    return true;
            return false;
        }

        public static Complex operator +(Complex Left, int num)
        {
            Complex temp = new();
            temp.Real = Left.Real + num;
            temp.Imagine = Left.Imagine + num;
            return temp;
        }

        public static Complex operator ++(Complex Left)
        {
            Complex temp = new();
            temp.Real = Left.Real + 1;
            temp.Imagine = Left.Imagine + 1;
            return temp;
        }
        public static Complex operator --(Complex Left)
        {
            Complex temp = new();
            temp.Real = Left.Real - 1;
            temp.Imagine = Left.Imagine - 1;
            return temp;
        }
        public override string ToString()
        {
            return $"({Real}, {Imagine})";
        }
    }
}
