using Seeding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seeding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(Customer model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
    }
}