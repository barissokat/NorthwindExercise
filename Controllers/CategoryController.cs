using NorthwindExercise.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindExercise.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindContext db = new NorthwindContext();
        // GET: Category
        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }
    }
}