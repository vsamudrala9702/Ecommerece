using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ECommerece.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AutoLogin()
        {
            Session["loggedinuser"] = "Vinay";
            Session["loggedInRoleId"] = "2";

            FormsAuthentication.SetAuthCookie("Vinay", true);

            return RedirectToAction("Index", "ManageProducts", new { });
        }
    }
}