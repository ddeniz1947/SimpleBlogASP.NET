using SimpleBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        /// <summary>
        /// when request made by get method executed
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {

            return View(new AuthLogin() { Test = "This is a value set in my post action " });
        }
        ///Post: Auth
        /// <summary>
        /// when request made by post method executed
        /// </summary>
        /// <param name="formData">Form data represent AuthLogin Class</param>
        /// <returns></returns>
        /// 
        [HttpPost]
        public ActionResult Login(AuthLogin formData)
        {
            if (!ModelState.IsValid)
            {
                return View(formData);
            }
            if(formData.UserName != "Trakya " && formData.Password!="12345" )
            {
                ModelState.AddModelError("UserName", "Username is not valid");
                return View(formData);
            }
            formData.Test = "This is a value set in my (Second) post action";
            // return Content("hi" + formData.UserName + "-" + formData.Password);
            //return View(formData);
            return Content("This is valid!");/*ModalState Geçerliliği için*/
            

        }
    }
}