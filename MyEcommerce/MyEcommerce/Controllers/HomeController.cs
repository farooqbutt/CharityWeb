using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyEcommerce.Data;
using MyEcommerce.InterfaceClasses;
using MyEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyEcommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext Context;

        public HomeController(ApplicationDbContext Context)
        {
            this.Context = Context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductClass product)
        {
            var RealProduct = new Product
            {
                ProductName = product.ProductName,
                ProductDescription = product.ProductDescription,
                ProductPrice = product.ProductPrice,
                PostedDatedTime = DateTime.Now,
                ProductStock = product.ProductStock,
                ProdctAuthor = User.Identity.Name
            };
            Context.Products.Add(RealProduct);
            Context.SaveChanges();
            var productImage = new ProductImage
            {
                ImageData = product.ProductImage,
                ProductIDforImage = RealProduct.Id
            };
            Context.ProductImages.Add(productImage);
            Context.SaveChanges();
            return RedirectToAction("ProductsList");
        }

        public IActionResult ProductsList()
        {
            var Productlist = Context.Products.ToList();
            List<ProductListInterfaceClass> ProductRealList = new List<ProductListInterfaceClass>();
            foreach (var item in Productlist)
            {
                var productitem = new ProductListInterfaceClass
                {
                    Id = item.Id,
                    ProductName = item.ProductName,
                    ProductDescription = item.ProductDescription,
                    ProductPrice = item.ProductPrice,
                    PostedDatedTime = item.PostedDatedTime,
                    ProductStock = item.ProductStock,
                    ProdctAuthor = item.ProdctAuthor,
                    ProductFirstImage = Context.ProductImages.Where(a => a.ProductIDforImage == item.Id).First().ImageData,
                    ProductReviewsCount=Context.Reviews.Where(a=>a.ProductID==item.Id).Count()
                };
                ProductRealList.Add(productitem);
            }
            return View(ProductRealList);
        }


        [HttpGet]
        public IActionResult ProductDescription(int ProductId)
        {
            var product = Context.Products.Find(ProductId);
            var productImages = Context.ProductImages.Where(a => a.ProductIDforImage == ProductId).ToList();
            var productReviews = Context.Reviews.Where(a => a.ProductID == ProductId).ToList();
            var tuple = new Tuple<Product, List<ProductImage>, List<Review>>(product, productImages, productReviews);
            return View(tuple);
        }


        [HttpGet]
        public IActionResult WriteReivew(int ProductId)
        {
            ViewBag.ProductID = ProductId;
            return View();
        }

        [HttpPost]
        public IActionResult WriteReivew(Review review)
        {
            Context.Reviews.Add(review);
            Context.SaveChanges();
            return RedirectToAction("ProductDescription", new { ProductId = review.ProductID });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
