using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ECommerece.CustomFilters
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class CustomAuthorization : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //base.OnAuthorization(filterContext);

            if (filterContext.HttpContext.Request.IsAuthenticated && HttpContext.Current.Session["loggedinuser"] != null && HttpContext.Current.Session["loggedInRoleId"] != null)
            {
                if (HttpContext.Current.Session["loggedInRoleId"].ToString() == "2")
                {

                }
                else
                {
                    // Not Authorized
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "AccessDenied", action = "Index", area = "" }));
                }
            }
            else
            {
                // Not Authenticated 
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "login", action = "Index", area = "" }));
            }
        }
    }
}