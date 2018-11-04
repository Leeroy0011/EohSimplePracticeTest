using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eoh_Entities
{
   public class Person
    {

        [Key]
        [Required]
        public int PersonID { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(128)]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(128)]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
    }
}
