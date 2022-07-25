using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyEcommerce.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public string ReviewDescription { get; set; }
        public int ReviewStars { get; set; }
        
        [ForeignKey("ForeignProductId")]
        public int ProductID { get; set; }
        public Product ForeignProductId { get; set; }
    }
}
