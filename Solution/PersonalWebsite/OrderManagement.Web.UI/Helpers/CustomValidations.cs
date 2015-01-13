using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OrderManagement.Web.UI
{
    public class AdminAuthorization : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            var Session = filterContext.HttpContext.Session;
            if (Session["AdminId"] != null)
            {
                //base.OnAuthorization(filterContext);
                return;
            }
            else
            {
                var redirectTarget = new RouteValueDictionary { { "action", "Login" }, { "controller", "AdminAccount" } };
                filterContext.Result = new RedirectToRouteResult(redirectTarget);
                return;
            }
        }
    }
}