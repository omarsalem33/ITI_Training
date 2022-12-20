using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class Person : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }

    
        public object Clone() 
        {
           Person p1 = new Person();
            p1.Name = this.Name;
            return p1;
             
        }

        public override string ToString()
        {
            return $"Id = {Id} , Name = {Name} , Salary = {Salary} , Age = {Age}";
        }
    }
}
