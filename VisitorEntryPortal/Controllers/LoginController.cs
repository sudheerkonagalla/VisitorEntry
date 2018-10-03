using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VisitorEntryPortal.BusinessLayer;
using VisitorEntryPortal.Models;

namespace VisitorEntryPortal.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Login(FormCollection LoginForm)
        {
            var username = LoginForm["txtuname"];
            var password = LoginForm["txtpswd"];
            Boolean isAucthenticated = Authentication.Authenticate(username, password);
            isAucthenticated = true;
            if (isAucthenticated)
            {
                Session["IsAuthenticated"] = 1;
                Session["UserName"] = username;
                company CompanyDetails =  Common.GetCompany(username);
                ViewBag.CompanyName = CompanyDetails.name;
                return View("~/Views/Home/Home.cshtml");
            }
            else
            {
                return RedirectToRoute("Login.cshtml");
            }
            
        }
    }
}