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

        StudentDataEF studentDataEF = new StudentDataEF();
/*


        public JsonResult Add(Student student)
        {
            return Json(studentDataEF.Add(student), JsonRequestBehavior.AllowGet);

        }



        public JsonResult List()
        {
            //return Json(studentDataEF.ListAll(), JsonRequestBehavior.AllowGet);
            return Json(studentDataEF.ListAllSP(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Delete(int id)
        {

            return Json(studentDataEF.Delete(id), JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetById(int id)
        {

            // var student = studentDataEF.ListAll().Find(studentDTO => studentDTO.StudentId.Equals(id));
            // return Json(student, JsonRequestBehavior.AllowGet);
            return Json(studentDataEF.GetById(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult Update(Student student)
        {

            return Json(studentDataEF.Update(student), JsonRequestBehavior.AllowGet);
        }*/
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
    }
}