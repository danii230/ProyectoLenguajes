using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1MVC.Models
{
    public class MajorDataEF
    {


        public List<MajorDTO> ListAll()
        {
            List<MajorDTO> major = null;

            using (var context = new LabMVC())
            {
                major = context.Major
                  .Select(majorItem => new MajorDTO()
                  {
                      MajorId = majorItem.MajorId,
                      Name = majorItem.Name,
                     

                  }).ToList<MajorDTO>();
            }

            return major;

        }
            public List<Major> ListAllSP()
        {
            using (var context = new LabMVC())
            {
                return context.SpSelectMajor().ToList();
            }

        }
    }
}