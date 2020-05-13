using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1MVC.Models
{
    public class ProvinceData
    {

        public List<ProvinceDTO> ListAll()
        {
            List<ProvinceDTO> province = null;

            using (var context = new Connection())
            {
                province = context.Province
                  .Select(provinceItem => new ProvinceDTO()
                  {
                      ProvinceId = provinceItem.ProvinceId,
                      Name = provinceItem.Name,
                  }).ToList<ProvinceDTO>();
            }

            return province;

        }

    }
}