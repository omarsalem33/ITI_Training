using System.ComponentModel.DataAnnotations.Schema;

namespace FirstLoook.Models
{
    public class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Address { get; set; }
        public int Age { get; set; }
        public string Image { get; set; }
      //  public bool IsDeleted { get; set; }


        // Make a relation 
        [ForeignKey ("Department")]
        public int DeptId { get; set; }
        // lazy loading ----> virtual  
        public virtual Department Department { get; set; }

    }
}
