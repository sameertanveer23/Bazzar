using Bazzar.Entities;
using Bazzar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bazzar.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductService productService = new ProductService();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listing()
        {
            var products = productService.ViewProduct().ToList();
            return View(products);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {

            productService.SaveProduct(product);
            return RedirectToAction("Listing");
        }
    }
}