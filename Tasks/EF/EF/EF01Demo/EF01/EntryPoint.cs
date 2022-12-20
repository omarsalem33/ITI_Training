using EF01.Entities;
using EF01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01
{
     class EntryPoint
    {
        static void Main()
        {
            CompanyContext Db = new CompanyContext();
            //Ef Datbase Creation startgy
            //Create Db For First time
            Db.Database.EnsureCreated();



            Employee E1 = new Employee {  Name = "Hamada", Age = 22, Salary = 2000 };
            Employee E2 = new Employee {  Name = "Hamada2", Age = 22, Salary = 2000 };
            ///Add Employee Object in Local Storage
            Db.Employees.Add(E2);
            ///Affect to Database
            Db.SaveChanges();



        }
    }
}
