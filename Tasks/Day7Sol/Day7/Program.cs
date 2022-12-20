using System;

namespace Day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string s1 = "omar";
            //string s2 = (String)s1.Clone();

            //Console.WriteLine("String : {0}", s1);
            //Console.WriteLine("Clone String : {0}", s2);



            Person person = new Person { Id = 1, Name = "Ali", Age = 25, Salary = 2000 };
            Person person1 = (Person)person.Clone();
            Console.WriteLine(person1);
            Console.WriteLine(person1.Name); 

        }
    }
}