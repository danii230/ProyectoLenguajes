using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab1MVC.Models
{
    public class StudentData
    {
       /* string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        //CRUD: Create, read, update, delete
        public int Add(Student student)
        {
            int resultToReturn;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("InsertUpdateStudent", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StudentId", student.StudentId);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Age", student.Age);
                command.Parameters.AddWithValue("@Nationality", student.Nationality.NationalityId);
                command.Parameters.AddWithValue("@Major", student.Major.MajorId);
                command.Parameters.AddWithValue("@Action", "Insert");
                
                resultToReturn = command.ExecuteNonQuery();
                connection.Close();
            }

            return resultToReturn;
        }


        //Return the list of all students
        public List<Student> ListAll()
        {
            List<Student> students = new List<Student>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectStudent", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads all the rows coming from DB
                while (sqlDataReader.Read())
                {
                    students.Add(new Student
                    {
                        StudentId = Convert.ToInt32(sqlDataReader["StudentId"]),
                        Name = sqlDataReader["Name"].ToString(),
                        Age = Convert.ToInt32(sqlDataReader["Age"]),
                        Nationality= new Nationality(Convert.ToInt32(sqlDataReader["NationalityId"]), sqlDataReader["NationalityName"].ToString()),
                        Major= new Major(Convert.ToInt32(sqlDataReader["MajorId"]), sqlDataReader["MajorName"].ToString())
                    }
                    );
                }
                connection.Close();
            }
            return students;
        }


        public Student GetById(int id)
        {
            Student student = new Student();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SelectStudentById", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentId", id);

                SqlDataReader sqlDataReader = command.ExecuteReader();
                //this reads the row coming from DB
                if (sqlDataReader.Read())
                {
                    student.StudentId = Convert.ToInt32(sqlDataReader["StudentId"]);
                    student.Name = sqlDataReader["Name"].ToString();
                    student.Age = Convert.ToInt32(sqlDataReader["Age"]);
                    student.Nationality = new Nationality(Convert.ToInt32(sqlDataReader["NationalityId"]), sqlDataReader["NationalityName"].ToString());
                    student.Major = new Major(Convert.ToInt32(sqlDataReader["MajorId"]), sqlDataReader["MajorName"].ToString());

                }
                connection.Close();
            }
            return student;
        }

        public int Update(Student student)
        {
            int resultToReturn;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("InsertUpdateStudent", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StudentId", student.StudentId);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@Age", student.Age);
                command.Parameters.AddWithValue("@Nationality", student.Nationality.NationalityId);
                command.Parameters.AddWithValue("@Major", student.Major.MajorId);
                command.Parameters.AddWithValue("@Action", "Update");
                resultToReturn = command.ExecuteNonQuery();
                connection.Close();
            }

            return resultToReturn;
        }

        public int Delete(int id)
        {
            int resultToReturn;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("DeleteStudent", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentId", id);
                resultToReturn = command.ExecuteNonQuery();
                connection.Close();
            }
            return resultToReturn;
        */

    }
    }