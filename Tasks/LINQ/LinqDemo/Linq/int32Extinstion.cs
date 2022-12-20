using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    static class int32Extinstion
    {
        public static int Mirror(this int i)
        {
            var R = i.ToString().ToCharArray();

            Array.Reverse(R);

            if (int.TryParse(new String(R), out int temp)) 
              return temp;

            return -1;


        }
    }
}
