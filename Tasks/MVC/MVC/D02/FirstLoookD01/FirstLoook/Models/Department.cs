using System.Collections.Generic;

namespace FirstLoook.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string  DeptName { get; set; }
        public int MGRId { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>(); 
    }
}
