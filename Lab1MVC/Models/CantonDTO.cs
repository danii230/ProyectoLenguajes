using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1MVC.Models
{
    public class CantonDTO
    {
        private int cantonId;
        private string name;

        public CantonDTO()
        {
        }

        public CantonDTO(int cantonId, string name)
        {
            this.cantonId = cantonId;
            this.name = name;
        }

        public int CantonId { get => cantonId; set => cantonId = value; }
        public string Name { get => name; set => name = value; }
    }
}