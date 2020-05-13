using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab1MVC.Models;

namespace Lab1MVC.Controllers
{
    public class EmailController : Controller
    {
        EmailData emailData = new EmailData();
        public JsonResult Add(string to)
        {
            return Json(emailData.SendEmail(to), JsonRequestBehavior.AllowGet);

        }
        // GET: Email
        public ActionResult Index()
        {
            return View();
        }
    }
}