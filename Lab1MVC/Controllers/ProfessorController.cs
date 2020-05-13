using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab1MVC.Models;

namespace Lab1MVC.Controllers
{
    public class ProfessorController : Controller
    {
        ProfessorData professorData = new ProfessorData();
        public JsonResult Add(App_User user, Professor professor)
        {
            return Json(professorData.Add(user, professor), JsonRequestBehavior.AllowGet);

        }
        // GET: Professor
        public ActionResult Index()
        {
            return View();
        }
    }
}