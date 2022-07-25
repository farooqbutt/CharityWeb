using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyEcommerce.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public float ProductPrice { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime PostedDatedTime { get; set; }
        public int ProductStock { get; set; }
        public string ProdctAuthor { get; set; }

    }
}
