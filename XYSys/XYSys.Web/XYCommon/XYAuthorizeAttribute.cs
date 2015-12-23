using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace XYSys.Web.XYCommon
{
    public class XYAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return base.AuthorizeCore(httpContext);
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //var area = filterContext.Controller.ControllerContext.RouteData.DataTokens["area"];
            //var rawUrl = filterContext.HttpContext.Request.RawUrl;
            //if (area == "Admin") 
            //{
            //    filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary(new { area = "Admin", controller = "Home", action = "Login", ReturnUrl = rawUrl }));
            //    return;
            //}
            base.HandleUnauthorizedRequest(filterContext);
        }
    }
}