using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the Super Ultra Contact Manager";

            return View();
        }

        public ActionResult Contacts()
        {
            ViewBag.Message = "You can use this page to view, add, edit, and delete contacts.";

            return View();
        }
    }
}
