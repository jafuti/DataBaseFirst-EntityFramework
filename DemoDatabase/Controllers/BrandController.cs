using DemoDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoDatabase.Controllers
{
    public class BrandController : Controller
    {
        // GET: Brand
        EFDBFirstDatabaseEntities4 _context;
        public BrandController()
        {
            _context = new EFDBFirstDatabaseEntities4();
        }
        public ActionResult Index()
        {
         var brands =  _context.Brands.ToList();
            return View(brands);
        }
    }
}