using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanzHow.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult PortfolioOneCol()
        {
            return View();
        }
        public ActionResult PortfolioTwoCol()
        {
            return View();
        }
        public ActionResult PortfolioThreeCol()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}