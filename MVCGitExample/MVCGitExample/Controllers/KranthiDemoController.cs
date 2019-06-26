using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGitExample.Controllers
{
    public class KranthiDemoController : Controller
    {
        // GET: KranthiDemo
        public ActionResult Index()
        {
            ViewBag.name = "Kranti";
            ViewBag.age = "25";
            ViewBag.Address = "Hyd";
            return View();
        }
    }
}