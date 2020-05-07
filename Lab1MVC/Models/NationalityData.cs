using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab1MVC.Models
{
    public class NationalityData
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public List<NationalityDTO> ListAll()
        {
            List<NationalityDTO> nationalities = new List<NationalityDTO>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectNationality", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    nationalities.Add(new NationalityDTO
                    {
                        NationalityId = Convert.ToInt32(sqlDataReader["NationalityId"]),
                        Name = sqlDataReader["Name"].ToString(),
                    }
                    );
                }
                connection.Close();
            }
            return nationalities;
        }
    }
}