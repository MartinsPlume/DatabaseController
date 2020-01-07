using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Controller.Models
{
    //ProductId
    //ProductName
    //ProductPrice
    //ProductRetailPrice
    //ProductWeight
    //ProductStock
    //ProductReserved
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string ProductName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string ProductCode { get; set; }
        [Required]
        [Column(TypeName = "Float")]
        public float Price { get; set; }
        [Required]
        [Column(TypeName = "Float")]
        public float RetailPrice { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int Weight { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int ProductStock { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int ProductReserved { get; set; }
    }
}
