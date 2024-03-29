﻿using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{usersid}",
                new { controller = "User", id = UrlParameter.Optional, usersid = UrlParameter.Optional }
            );
        }
    }
}