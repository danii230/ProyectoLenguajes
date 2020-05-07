using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab1MVC.Models;

namespace Lab1MVC.Controllers
{
    public class MajorController : Controller
    {

        MajorDataEF majorDataEF = new MajorDataEF();

        public JsonResult List()
        {
            return Json(majorDataEF.ListAll(), JsonRequestBehavior.AllowGet);
           // return Json(majorDataEF.ListAllSP(), JsonRequestBehavior.AllowGet);
        }

        // GET: Major
        public ActionResult Index()
        {
            return View();
        }
    }
}