using Lab1MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1MVC.Controllers
{
    public class StudentController : Controller
    {

        StudentData studentData = new StudentData();

        public JsonResult Add(App_User user)
        {
            return Json(studentData.Add(user), JsonRequestBehavior.AllowGet);

        }


        public ActionResult Index()
        {
            return View();
        }
    }
}