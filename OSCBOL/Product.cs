using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OSCBOL
{
    [Table("Product")]public class Product
    {
        [Key]public int ProductId { get; set; }
        [Required]public string ProductName { get; set; }
        [Required]public double ProductPrice { get; set; }
        public int StockAvailable { get; set; }
        [NotMapped]
        public string Status { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
