﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1MVC.Models
{
    public class ProfessorData
    {

        public int Add(App_User user, Professor professor)
        {
            int resultToReturn;

            using (var context = new Connection())
            {
                resultToReturn = context.SpAdd_Professor(user.Email, user.Password, user.Name, user.LastName, user.Phone, user.Province, user.Canton, "Oreamuno", professor.IsAdmin );
            }

            return resultToReturn;


        }
    }
}