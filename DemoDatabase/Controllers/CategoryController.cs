using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoDatabase.Models;
namespace DemoDatabase.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        EFDBFirstDatabaseEntities4 _context = new EFDBFirstDatabaseEntities4();
        public ActionResult Index()
        {
     var category =  _context.Categories.ToList();
            return View(category);
        }
    }
}