using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class sampController : Controller
    {
        // GET: samp
        public ActionResult Index()
        {
            ViewData["info"] = "Hi";

            return View();
        }
    }
}