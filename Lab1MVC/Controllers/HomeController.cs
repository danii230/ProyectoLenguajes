﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Professor()
        {
            return View();
        }

        public ActionResult Student()
        {
            return View();
        }
    }
}