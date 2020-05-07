using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab1MVC.Models;

namespace Lab1MVC.Controllers
{
    public class NationalityController : Controller
    {
        NationalityDataEF nationalityData = new NationalityDataEF();

        public JsonResult List()
        {
            return Json(nationalityData.ListAll(), JsonRequestBehavior.AllowGet);
           // return Json(nationalityData.ListAllSP(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}