using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    [Table("Emp")]
    public class EmployeeV02
    {
        [Key]//Identity
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int SSN { get; set; }
        [Range(18,60)]
        public int? Age { get; set; }
        [Range(2500,6000)]
        public int? Salary { get; set; }
        [EmailAddress]
        public String? Email { get; set; }
        [StringLength(50)]
        public String? Address { get; set; }
        //[RegularExpression("")]
        public string? Password { get; set; }
        [ForeignKey("Department")]
        public int? DeptId { get; set; }
        public virtual Department Department { get; set; }
    }
}
