using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1MVC.Models
{
    public class StudentData
    {
        public int Add(App_User user)
        {
            int resultToReturn;

            using (var context = new Connection())
            {
                resultToReturn = context.SpAdd_Student(user.Email, user.Password, user.Name, user.LastName, user.Phone, user.Province, user.Canton, "Oreamuno", user.Interest);
            }

            return resultToReturn;


        }
    }
}