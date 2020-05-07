using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1MVC.Models
{
    public class StudentDataEF
    {
        public List<SelectStudent_Result> ListAllSP()
        {
            using (var context = new LabMVC())
            {
                return context.SpSelectStudent().ToList();
            }

        }

        public int Add(Student student)
        {
            int resultToReturn;

            using (var context = new LabMVC())
            {
                resultToReturn = context.SpInsertUpdateStudent(student.StudentId, student.Name, student.Age, student.StudentNationality.NationalityId, student.StudentMajor.MajorId, "Insert");
            }

            return resultToReturn;


        }

        public SelectStudentById_Result GetById(int id)
        {

            SelectStudentById_Result resultToReturn;

            using (var context = new LabMVC())
            {
                resultToReturn = context.SpSelectStudentById(id).Single();
            }

            return resultToReturn;

        }

        public int Update(Student student)
        {
            int resultToReturn;

            using (var context = new LabMVC())
            {
                resultToReturn = context.SpInsertUpdateStudent(student.StudentId, student.Name, student.Age, student.StudentNationality.NationalityId, student.StudentMajor.MajorId, "Update");
            }

            return resultToReturn;


        }


        public int Delete(int id)
        {
            int resultToReturn;

            using (var context = new LabMVC())
            {
                resultToReturn = context.SpDeleteStudent(id);

                return resultToReturn;
            }
        }
    }
}