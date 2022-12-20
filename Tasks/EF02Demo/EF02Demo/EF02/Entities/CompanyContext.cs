using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF02.Models;
using Microsoft.EntityFrameworkCore;

namespace EF02.Entities
{
    public class CompanyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=.;Database=EFD02Core;Trusted_Connection=True");
            optionsBuilder.UseSqlServer("Server=.;Database=EFD02CoreV02;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Employee> Employees { set; get; }
        public virtual DbSet<EmployeeV02> EmployeeV02s { set; get; }
        public virtual DbSet<Department> Departments { set; get; }
    }
}
