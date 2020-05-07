using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1MVC.Models
{
    public class ProvinceDTO
    {
        private int provinceId;
        private string name;

        public ProvinceDTO()
        {
        }

        public ProvinceDTO(int provinceId, string name)
        {
            this.provinceId = provinceId;
            this.name = name;
        }

        public int ProvinceId { get => provinceId; set => provinceId = value; }
        public string Name { get => name; set => name = value; }
    }
}