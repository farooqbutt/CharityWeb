using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEcommerce.InterfaceClasses
{
    public class ProductListInterfaceClass
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public float ProductPrice { get; set; }
        public DateTime PostedDatedTime { get; set; }
        public int ProductStock { get; set; }
        public string ProdctAuthor { get; set; }
        public string ProductFirstImage { get; set; }
        public int ProductReviewsCount { get; set; }
    }
}
