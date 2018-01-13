using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab1.Controllers
{
    public class PersonController: Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ViewBag.Message = "My people!";
            return View();
        }
    }
}