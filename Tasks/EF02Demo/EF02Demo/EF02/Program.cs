using EF02.Entities;
using EF02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02
{
    internal class Program
    {
        static void Main()
        {
            
            CompanyContext Db = new CompanyContext();
            #region V01
            //Db.Database.EnsureDeleted();
            //Db.Database.EnsureCreated();

            //Employee e1 = new Employee() { Name = "Hamada", Age = 20, Salary = 5000 };

            //Db.Employees.Add(e1);

            //Department d = new Department() { DeptName = "SD" };

            //Db.Departments.Add(d);

            //Db.SaveChanges(); 
            #endregion


            //Db.Database.EnsureDeleted();
            #region Add Departments
            //Db.Database.EnsureCreated();
            ////Department d = new Department() { DeptName = "SD" };
            ////Department d1 = new Department() { DeptName = "UI" };
            ////Department d2 = new Department() { DeptName = "OS" };
            ////Db.Departments.Add(d);
            ////Db.Departments.Add(d1);
            ////Db.Departments.Add(d2);
            ////Db.SaveChanges();
            ////var d = Db.Departments.Where(d => d.Id == 8);
            ////Console.WriteLine(d); 
            #endregion

            #region Add Employees
            // Employee e1 = new Employee() { Name = "Hamada", Age = 20, Salary = 5000, DepartmentId = 1};
            // Employee e2 = new Employee() { Name = "Sara", Age = 20, Salary = 5000, DepartmentId = 2 };
            // Employee e3 = new Employee() { Name = "Ali", Age = 20, Salary = 5000, DepartmentId = 3 };
            // Employee e4 = new Employee() { Name = "Ali", Age = 20, Salary = 5000, DepartmentId = 1 };


            // //Db.Employees.Add(e1);

            // //Db.Add(e2);
            //Db.Employees.AddRange(new Employee[] { e1, e2, e3 ,e4});
            // Db.SaveChanges(); 
            #endregion

            #region GetAllEmps
            ////var result = from e in Db.Employees
            ////             select e;

            ////var result = Db.Employees.Find(3);

            //var result = Db.Employees.Include(d => d.Department);
            ////Console.WriteLine(result);
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Update Emp

            //var e = Db.Employees.Find(4);
            //e.Name = "Ahmed";

            //Employee e1 = new Employee() { Id = 1, Name = "Hussien", Age = 22 , DepartmentId = 2 };
            //Db.Update(e1);
            //Db.SaveChanges();



            #endregion


            #region Delete

            //var e = Db.Employees.FirstOrDefault(e=>e.Id == 4);   
            //Db.Remove(e);
            //Db.SaveChanges();

            #endregion

        }
    } 
}
