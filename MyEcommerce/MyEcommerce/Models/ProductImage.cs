using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyEcommerce.Models
{
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }
        public string ImageData { get; set; }

        [ForeignKey("ForeignImageProductId")]
        public int ProductIDforImage { get; set; }
        public Product ForeignImageProductId { get; set; }

    }
}
