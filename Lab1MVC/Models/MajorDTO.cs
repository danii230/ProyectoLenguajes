using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1MVC.Models
{
    public class MajorDTO
    {
        private int majorId;
        private string name;

        public MajorDTO()
        {
        }

        public MajorDTO(int majorId, string name)
        {
            this.majorId = majorId;
            this.name = name;
        }

        public int MajorId { get => majorId; set => majorId = value; }
        public string Name { get => name; set => name = value; }

    }
}