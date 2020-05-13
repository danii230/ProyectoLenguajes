using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab1MVC.Models;

namespace Lab1MVC.Controllers
{
    public class ProvinceController : Controller
    {


        ProvinceData provinceData = new ProvinceData();

        public JsonResult List()
        {
             return Json(provinceData.ListAll(), JsonRequestBehavior.AllowGet);
           // return Json(provinceData.ListAllSp(), JsonRequestBehavior.AllowGet);

        }

        // GET: Province
        public ActionResult Index()
        {
            return View();
        }
    }
}