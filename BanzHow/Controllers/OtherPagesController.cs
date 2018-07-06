using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanzHow.Controllers
{
    public class OtherPagesController : Controller
    {
        // GET: OtherPages
        public ActionResult FullWidth()
        {
            return View();
        }
        public ActionResult Sidebar()
        {
            return View();
        }
        public ActionResult Faq()
        {
            return View();
        }
        public ActionResult Error404()
        {
            return View();
        }
    }
}