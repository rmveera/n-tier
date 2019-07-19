using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OSCBOL
{
    [Table("Customer")]public class Customer
    {
        [Key] public int CustomerId { get; set; }
        [Required] public string CustomerName { get; set; }
        [EmailAddress,Required] public string Email { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
