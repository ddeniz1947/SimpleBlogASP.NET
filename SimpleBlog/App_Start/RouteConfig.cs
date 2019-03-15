using SimpleBlog.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var namespaces = new[] { typeof(HomeController).Namespace };
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Home","", new {controller="Home",action="Index"},namespaces);
            routes.MapRoute("Login", "Login", new { controller = "Auth", action = "Login" },namespaces);
            routes.MapRoute("Register", "Register", new { controller = "Register", action = "Register" }, namespaces);

        }
    }
}
