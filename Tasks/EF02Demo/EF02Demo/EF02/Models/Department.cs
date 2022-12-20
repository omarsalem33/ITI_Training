using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    public class Department
    {
        //public int DepartmentID { get; set; }
        public int Id { get; set; }
        public string DeptName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }=new HashSet<Employee>();
        public virtual ICollection<EmployeeV02> EmployeeV02s { get; set; }=new HashSet<EmployeeV02>();
        public override string ToString()
        {
            return $"{DeptName}";
        }
    }
}
