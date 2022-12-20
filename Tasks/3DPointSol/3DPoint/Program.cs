using System;

namespace _3DPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Point 3D //
            bool check;
            int x, y, z;
            do
            {
                Console.WriteLine("enter x:");
                check = int.TryParse(Console.ReadLine(), out x);

            } while (!check);
            do
            {
                Console.WriteLine("enter y:");
                check = int.TryParse(Console.ReadLine(), out y);

            } while (!check);

            do
            {
                Console.WriteLine("enter z:");
                check = int.TryParse(Console.ReadLine(), out z);

            } while (!check);
            _3D p3 = new _3D(x, y, z);
            Console.WriteLine(p3);

            
            ///try catch///
            int sum = Math.add(42, 54);
            int mul = Math.mul(2, 4);
            int sub = Math.sub(2, 40);

            Console.WriteLine($"Sum is  = {sum} // Mul is = {mul} // Sub is = {sub}");


            try
            {
                int div = Math.div(49, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
            //// Math && Complex ////
            Complex c1 = new Complex(10, 23);
            Complex c2 = new Complex(10, 45);
            Complex c3 = new Complex();
            c3 = c1 + c2;
            Complex c4 = new Complex();
            c4 = c1 + 7;
            c3 = ++c1;
            c4 = c2++;
            bool cheeck1 = c3 > c1;
            bool cheeck2 = c3 < c2;
            bool cheeck3 = c4 >= c2;
            bool cheeck4 = c2 <= c3;
            c4 = --c2;
            
            Console.WriteLine($"C1 is = {c1} //  C2 is = {c2} //  C3 is = {c3} //  C4 is = {c4} ");
            Console.WriteLine($"cheeck1 is = {cheeck1} //  cheeck2 is = {cheeck2} \ncheeck3 is = {cheeck3} //  cheeck4 is = {cheeck4} ");



        }
    }
}
