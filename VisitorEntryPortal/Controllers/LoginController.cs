using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VisitorEntryPortal.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Login(string Username, string Password)
        //{

        //    return View();
        //}
        [HttpPost]
        public ActionResult Login(FormCollection LoginForm)
        {
            var username = LoginForm["txtuname"];
            var password = LoginForm["txtpswd"];
            if(username.Equals("admin") && password.Equals("admin"))
            {
                Session["IsAuthenticated"] = 1;
                Session["UserName"] = username;
                return View("~/Views/Home/index.cshtml");
            }
            else
            {
                return RedirectToRoute("Login.cshtml");
            }
            
        }
    }
}