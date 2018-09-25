using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VisitorEntryPortal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult LateLogoutRegister()
        {
            return PartialView("_LateLogout");
        }
        //[HttpPost]
        public ActionResult Test(string viewName)
        {
            return PartialView(viewName);
        }
    }
}