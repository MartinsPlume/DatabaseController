using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Controller.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string email { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int PostalCode { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int ProductId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Status { get; set; }
    }
}
