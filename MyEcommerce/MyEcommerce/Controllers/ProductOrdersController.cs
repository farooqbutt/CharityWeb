﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyEcommerce.Data;
using MyEcommerce.Models;

namespace MyEcommerce.Controllers
{
    public class ProductOrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductOrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProductOrders
        public async Task<IActionResult> Index()
        {
            if (User.IsInRole("Customer"))
            {
                return View(await _context.ProductOrders.
                    Include(a => a.Product_Id).Where(a => a.OrderingPersonEmail == User.Identity.Name).ToListAsync());
            }
            else
            {
                return View(await _context.ProductOrders.
                    Include(a => a.Product_Id).ToListAsync());
            }

        }

        // GET: ProductOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productOrder = await _context.ProductOrders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productOrder == null)
            {
                return NotFound();
            }

            return View(productOrder);
        }

        // GET: ProductOrders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductId,Quantity,OrderDate,ItemAmount,OrderTotalAmount,OrderStatus,Email,PhoneNumber,AddressDetails,OrderingPersonEmail")] ProductOrder productOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productOrder);
        }

        // GET: ProductOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productOrder = await _context.ProductOrders.FindAsync(id);
            if (productOrder == null)
            {
                return NotFound();
            }
            return View(productOrder);
        }

        // POST: ProductOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductId,Quantity,OrderDate,ItemAmount,OrderTotalAmount,OrderStatus,Email,PhoneNumber,AddressDetails,OrderingPersonEmail")] ProductOrder productOrder)
        {
            if (id != productOrder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductOrderExists(productOrder.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(productOrder);
        }

        // GET: ProductOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productOrder = await _context.ProductOrders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productOrder == null)
            {
                return NotFound();
            }

            return View(productOrder);
        }

        // POST: ProductOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productOrder = await _context.ProductOrders.FindAsync(id);
            _context.ProductOrders.Remove(productOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductOrderExists(int id)
        {
            return _context.ProductOrders.Any(e => e.Id == id);
        }
    }
}
