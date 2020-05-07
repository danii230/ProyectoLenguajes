using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1MVC.Models
{
    public class ProfessorData
    {

        public int Add(Professor professor)
        {
            int resultToReturn;

            using (var context = new Proyecto1LenguajesB53953Entities())
            {
                resultToReturn = context.SpAdd_Professor(professor.ProfessorId, professor.Email, professor.Password, professor.Name, professor.LastName, professor.Phone, professor.Province, professor.Canton, professor.District, professor.IsAdmin);
            }

            return resultToReturn;


        }
    }
}