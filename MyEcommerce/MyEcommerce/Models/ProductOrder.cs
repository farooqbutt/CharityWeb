using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyEcommerce.Models
{
    public class ProductOrder
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Product_Id")]
        public int ProductId { get; set; }
        public Product Product_Id { get; set; }
        public int Quantity { get; set; }
        public DateTime? OrderDate { get; set; }
        public decimal ItemAmount { get; set; }
        public decimal OrderTotalAmount { get; set; }
        public string OrderStatus { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressDetails { get; set; }
        public string OrderingPersonEmail { get; set; }
    }
}
