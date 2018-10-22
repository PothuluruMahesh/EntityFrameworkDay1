using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFWExamples1.Models;

namespace EntityFWExamples1.Controllers
{
    public class NorthwindController1 : Controller
    {
        NorthwindContext1 db = new NorthwindContext1();
        public ActionResult Index()
        {
            
            db.CategoriesTable.ToList();
            db.ProductsTable.ToList();
            return View();
        }
    }
}