using lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Person pr = new Person();
            pr.Id = 1;
            pr.Name = "Tanvir";
            pr.Dob = "19-39570-1";
            return View(pr);
        }
    }
}