using System;
using Microsoft.AspNetCore.Mvc;
using Northwind.Models;
using System.Linq;

namespace Northwind.Controllers
{
    public class ProductController : Controller
    {
        private NorthwindContext _northwindContext;
        public ProductController(NorthwindContext db) => _northwindContext = db;

        public IActionResult Category() => View(_northwindContext.Categories.OrderBy(c => c.CategoryName));
        public IActionResult CategoryDetail(int id) => View(new CategoryViewModel
        {
            category = _northwindContext.Categories.FirstOrDefault(b => b.CategoryId == id),
            Products = _northwindContext.Products.Where(b => b.CategoryId == id).OrderBy(p => p.ProductName)
        });
        public IActionResult Discount() => View(_northwindContext.Discounts.Where(d => d.StartTime <= DateTime.Now && d.EndTime > DateTime.Now));
    }
}