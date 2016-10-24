using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tripenticer.Models;

namespace tripenticer.Controllers
{
    public class PropertyController : Controller
    {

        PackageContext PackageDB = new PackageContext();

        // GET: Properties
        public ActionResult Index()
        {
            List<Property> Properties = PackageDB.Properties.ToList();

            return View(Properties);
        }

        public ActionResult Details(int id = 1)
        {
            Property property = PackageDB.Properties.Find(id);

            return View(property);
        }
    }
}