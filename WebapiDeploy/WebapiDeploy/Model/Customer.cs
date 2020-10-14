using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebapiDeploy.Model
{
    [Table("Customers")]
    public class Customer
    {
        [Column("CustomerID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int CustomerID { get; set; }

        [Column("CompanyName")]
        [Required]
        [StringLength(100)]
        public string CompanyName { get; set; }
    }
}
