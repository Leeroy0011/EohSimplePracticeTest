using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Eoh_Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

      
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(16)]
        public string EmployeeNumber { get; set; }
        [Required]
        public DateTime EmployedDate { get; set; }
        public DateTime? TerminatedDate { get; set; }
  
        [Required]
        public int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public Person Person { get; set; }
    }
}
