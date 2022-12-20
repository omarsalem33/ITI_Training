using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
        
    public class LibraryEngine
    {
        public delegate string GatValue(string s);
        FPTR fptr = new FPTR(BookFunctions.GetTitle());
        public static void ProcessBooks(List<Book> bList , FPTR fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
