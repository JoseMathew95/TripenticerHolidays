using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tripenticer.Models;


namespace tripenticer.Controllers
{
    public class PackageController : Controller
    {
        PackageContext PackageDB = new PackageContext();

        // GET: Properties
        public ActionResult Index()
        {
            List<Package> Packages = PackageDB.Packages.ToList();

            return View(Packages);
        }

        public ActionResult Details(int id = 1)
        {
            Package package = PackageDB.Packages.Find(id);

            return View(package);
        }
    }
}