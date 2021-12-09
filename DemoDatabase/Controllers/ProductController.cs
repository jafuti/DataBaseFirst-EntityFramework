using DemoDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoDatabase.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        EFDBFirstDatabaseEntities4 _context;
        public ProductController()
        {
            _context = new EFDBFirstDatabaseEntities4();
        }
        public ActionResult Index(string search ="" )
        {
            ViewBag.search = search;
            var product = _context.Products.Where(temp => temp.ProductName.Contains(search)).ToList();
            return View(product);
        }
        public ActionResult Details(long id)
        {
       var product = _context.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            return View(product);
        }
       
    }
}