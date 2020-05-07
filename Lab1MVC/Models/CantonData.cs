using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1MVC.Models
{
    public class CantonData
    {
        public List<CantonDTO> ListAll()
        {
            List<CantonDTO> canton = null;

            using (var context = new Proyecto1LenguajesB53953Entities())
            {
                canton = context.Canton
                  .Select(cantonItem => new CantonDTO()
                  {
                      CantonId = cantonItem.CantonId,
                      Name = cantonItem.Name,
                  }).ToList<CantonDTO>();
            }

            return canton;

        }

    }
}