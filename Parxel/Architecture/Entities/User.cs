using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Column(TypeName="varchar(20)")]
        public string FirstName { get; set; }
        
        [Column(TypeName = "varchar(20)")]
        public string LastName { get; set; }
        
        public DateTime DOB { get; set; }
        
        [Column(TypeName = "varchar(20)")]
        public string CountryCode { get; set; }
        
        public int Mobile { get; set; }
    }
}
