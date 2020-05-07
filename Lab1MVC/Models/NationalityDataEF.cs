using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1MVC.Models
{
    public class NationalityDataEF
    {

        public List<NationalityDTO> ListAll()
        {
            List<NationalityDTO> nationality = null;

            using (var context = new LabMVC())
            {
                nationality = context.Nationality
                  .Select(nationalityItem => new NationalityDTO()
                  {
                      NationalityId = nationalityItem.NationalityId,
                      Name = nationalityItem.Name,


                  }).ToList<NationalityDTO>();
            }

            return nationality;

        }
        public List<Nationality> ListAllSP()
        {
            using (var context = new LabMVC())
            {
                return context.SpSelectNationality().ToList();
                    
            }

        }
    }
}