using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DPoint
{
    internal class _3D : Point
    {
        int z;
        public int zz
        {
            set
            {
                z = value;
            }
            get
            {
                return z;
            }
        }

        public _3D(int _x, int _y, int _z) : base(_x, _y)
        {
            z = _z;
        }

        public override string ToString()
        {
            return base.ToString() + " " + $"{zz}";
        }

    }
}
