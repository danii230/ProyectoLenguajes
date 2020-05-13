using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1MVC.Models
{
    public class StudentDTO
    {

        public int professorId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public bool Admited { get; set; }

        public string ProvinceName { get; set; }
        public string CantonName { get; set; }
        public int ProvinceId { get; set; }
        public int CantonId { get; set; }
    }
}