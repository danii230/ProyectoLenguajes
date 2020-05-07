using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1MVC.Models
{
    public class StudentDTO
    {

        public int StudentId { get; set; }
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public NationalityDTO Nationality { get; set; }
        public  MajorDTO Major { get; set; }
    }
}