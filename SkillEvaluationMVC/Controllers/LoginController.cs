using SkillEvaluationMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SkillEvaluationMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            if(loginModel.UserEmail != "" && loginModel.Password != "")
            {
                return RedirectToAction("Home", "Home");
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}