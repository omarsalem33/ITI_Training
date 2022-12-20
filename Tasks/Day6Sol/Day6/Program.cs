using System;

namespace Day6
{
    internal class Program
    {

        #region singleTon
        /*
        // old version//////////////////////////////////// 
        class SingleTon
        {
            public string? Data { get; set; }
            SingleTon()
            {
                Data = "Single TOn DP ...";
               Console.WriteLine(Data);
            }

            static SingleTon obj;
            /* public static SingleTon GetSingleTon()
             {
                 if(obj == null) 
                    obj = new SingleTon();
                 return obj;
             }*/
            ///////////////////////////////////////////

            /*static SingleTon()
            {
                obj = new SingleTon();
            }
            public static SingleTon Obj 
            {
                get
                { 
                    if (obj == null)
                        obj = new SingleTon();
                    return obj;

                }
            }
            */
            /*
            // C# version //
            public static SingleTon Obj { get; } = new SingleTon();
        }*/
        #endregion


        static void Main(string[] args)
        {
            #region Task

            
            // Point 
            Point p1 = new Point(4, 5);
            Point p2 = new Point(4, 5);
            Point p3 = new Point(5, 4);
            Console.WriteLine(Object.Equals(p1, p2)?"YES" :"NO");//  check of HashCode;
            Console.WriteLine(p1 == p2 ? "YES" : "NO");// check of  state
            Console.WriteLine(p2 == p3 ? "YES" : "NO");
            /////////////////////////////////////////////////////
            bool check ; 
            NIC o1 = NIC.obj;
            Console.WriteLine($"Hash code is {o1.GetHashCode()} ");
            Console.WriteLine("enter a Mac");
            
            string Mac = Console.ReadLine();
            //Console.WriteLine("enter a Ethernet");
            
            Type typeNIC;
            do
            {
                Console.WriteLine("enter a  type of NIC ");
                check = Type.TryParse<Type>(Console.ReadLine(), out typeNIC);
                if (check == false)
                    Console.WriteLine("you enter invalid format ,please try againe ");
            } while(!check);

            o1.getData(Mac , typeNIC);
          

            Console.WriteLine($"Mac -> {Mac} // Type -> {typeNIC}");
            #endregion





        }
    }
}
