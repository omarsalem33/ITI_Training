using Microsoft.EntityFrameworkCore;

namespace FirstLoook.Models
{
    public class CompanyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=.;Database=MVCD02Company;trusted-intgrated=True;");
       
            optionsBuilder.UseSqlServer("Data Source=OMAR;Initial Catalog=Task;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }
}
