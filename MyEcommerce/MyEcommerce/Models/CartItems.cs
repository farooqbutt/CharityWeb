using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyEcommerce.Models
{
    public class CartItems
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ForeignProductID")]
        public int ProductId { get; set; }
        public Product ForeignProductID { get; set; }
        public int Quantity { get; set; }
        public string CartOwner { get; set; }
    }
}
