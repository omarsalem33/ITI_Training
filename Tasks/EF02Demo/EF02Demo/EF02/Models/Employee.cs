﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public override string ToString() => $"{Id} : {Name} : {Age} : {Department}";
       
    }
}
