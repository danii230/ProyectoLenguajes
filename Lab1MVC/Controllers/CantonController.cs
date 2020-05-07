using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab1MVC.Models;

namespace Lab1MVC.Controllers
{
    public class CantonController : Controller
    {

        CantonData cantonData = new CantonData();

        public JsonResult List()
        {
            return Json(cantonData.ListAll(), JsonRequestBehavior.AllowGet);

        }
        // GET: Canton
        public ActionResult Index()
        {
            return View();
        }
    }
}