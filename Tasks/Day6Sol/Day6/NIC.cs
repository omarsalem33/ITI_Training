using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class NIC
    {
        // single ton ---> create a only one obj C#
        public static NIC obj { get; } = new NIC();
        public string Mac { get; set; }
        Type Enum { get; set; } 
        public  void getData(string sM , Type TypeNic)
        {
            Mac = sM;
            Enum = TypeNic;
        }

        public Type EnumType;
        public override string ToString()
        {
            return $" (MAc is  {Mac}  Type is = {Type.Ethernet} // {Type.Token })";
        }


    }
}
