using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyEcommerce.Data;
using MyEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEcommerce.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ApplicationDbContext Context;

        public PaymentController(ApplicationDbContext Context)
        {
            this.Context = Context;
        }

        public int CheckoutItemsCount(string userid)
        {
            var cartitemsCount = Context.CartItemsTobuy.Where(a => a.CartOwner == userid).Count();
            return cartitemsCount;
        }


        [Authorize]
        public IActionResult Checkout(string userid)
        {
            var cartitemsLsit = Context.CartItemsTobuy.Where(a => a.CartOwner == userid).ToList();
            cartitemsLsit.ForEach(a => a.ForeignProductID = Context.Products.Find(a.ProductId));
            return View(cartitemsLsit);
        }


        [Authorize]
        public string AddItemtoCart(int Productid)
        {
            var cartitem = new CartItems
            {
                ProductId = Productid,
                Quantity = 1,
                CartOwner = User.Identity.Name
            };
            Context.CartItemsTobuy.Add(cartitem);
            Context.SaveChanges();
            return Context.Products.Find(Productid).ProductName + " added to your Shopping Cart Successfully!";
        }

        public IActionResult ItemImageRetreiver(int productid)
        {
            var img = Context.ProductImages.Where(a => a.ProductIDforImage == productid).FirstOrDefault().ImageData;
            img = img.Substring(img.LastIndexOf(',') + 1);
            var bytes = Convert.FromBase64String(img);
            return File(bytes,"image/png");
        }

        public IActionResult IncreasItemQuantity(int cartitemId)
        {
            var cartItem = Context.CartItemsTobuy.Find(cartitemId);
            cartItem.Quantity = cartItem.Quantity + 1;
            Context.Entry(cartItem).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
            return RedirectToAction("Checkout", new { userid = User.Identity.Name });
        }

        public IActionResult DecreaseItemQuantity(int cartitemId)
        {
            var cartItem = Context.CartItemsTobuy.Find(cartitemId);
            cartItem.Quantity = cartItem.Quantity - 1;
            Context.Entry(cartItem).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
            if (cartItem.Quantity == 0)
            {
                Context.CartItemsTobuy.Remove(cartItem);
                Context.SaveChanges();
            }
            return RedirectToAction("Checkout", new { userid = User.Identity.Name });
        }

        public IActionResult RemoveCartItem(int itemid)
        {
            var item = Context.CartItemsTobuy.Find(itemid);
            Context.CartItemsTobuy.Remove(item);
            Context.SaveChanges();
            return RedirectToAction("Checkout", new { userid = User.Identity.Name });
        }

        public string CreateOrder(int[] ids, int[] quantities, decimal[] prices, string email, string phone, string address)
        {
            if (ids.Count() == quantities.Count() && quantities.Count() == prices.Count()) 
            {
                for (int i = 0; i < ids.Count(); i++)
                {
                    var productOrder = new ProductOrder
                    {
                        ProductId = ids[i],
                        Quantity = quantities[i],
                        ItemAmount = prices[i],
                        OrderTotalAmount = quantities[i] * prices[i],
                        OrderDate = DateTime.Now,
                        OrderStatus = "Pending",
                        Email = email,
                        PhoneNumber = phone,
                        AddressDetails = address,
                        OrderingPersonEmail = User.Identity.Name
                    };
                    Context.ProductOrders.Add(productOrder);
                    Context.SaveChanges();
                }
            }
            //for updating products stock 
            for (int i = 0; i < ids.Count(); i++) 
            {
                var product = Context.Products.Find(ids[i]);
                product.ProductStock = product.ProductStock - quantities[i];
                Context.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                Context.SaveChanges();
            }
            //for removing products from cart after placing order
            for (int i = 0; i < ids.Count(); i++)
            {
                var itemToRemove = Context.CartItemsTobuy
                    .Where(a => a.ProductId == ids[i] && a.CartOwner == User.Identity.Name).FirstOrDefault();
                Context.CartItemsTobuy.Remove(itemToRemove);
                Context.SaveChanges();
            }
            return "Order has been Placed Successfully!";
        }
    }
}
