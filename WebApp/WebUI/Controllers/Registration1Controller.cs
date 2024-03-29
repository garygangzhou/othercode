﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUI.HtmlHelpers;

namespace WebUI.Controllers
{
    public class Registration1Controller : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ActionResult SubmitRegistration(string myCaptcha, string attempt)
        {
            if (CaptchaHelper.VerifyAndExpireSolution(HttpContext, myCaptcha, attempt))
            {
                // In a real app, actually register the user now
                return Content("Pass");
            }
            else
            {
                // In a real app, redisplay the view with an error message
                return Content("Fail");
            }
        }
    }
}