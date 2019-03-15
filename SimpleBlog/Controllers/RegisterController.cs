using SimpleBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        // GET: Auth
        /// <summary>
        /// when request made by get method executed
        /// </summary>
        /// <returns></returns>
        public ActionResult Register()
        {

            return View(new RegisterRegister() { Test = "This is a value set in my post action " });
        }
        ///Post: Auth
        /// <summary>
        /// when request made by post method executed
        /// </summary>
        /// <param name="formData">Form data represent AuthLogin Class</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Login(RegisterRegister formData)
        {
           
             
            return Content("Name"+ formData.Name + " " + formData.Email);/*ModalState Geçerliliği için*/

           /* formData.StudentNumber
        }
    }
}