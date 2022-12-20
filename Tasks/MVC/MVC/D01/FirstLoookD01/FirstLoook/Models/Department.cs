using System.Collections.Generic;

namespace FirstLoook.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DpetName { get; set; }
        public int MGRId { get; set; }  
        public ICollection <Employee> Employees { get; set; } = new List<Employee>();


    }
}
