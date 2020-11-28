using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class StudentRepository
    {
        public List<Student>GetAllStudents()
        {
            List<Student> results = new List<Student>();

            using(SqlConnection sqlconnection = new SqlConnection(Constants.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlconnection;
                sqlCommand.CommandText = "SELECT * FROM students";

                sqlconnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Student s = new Student();

                    s.Id = sqlDataReader.GetInt32(0);
                    s.Name = sqlDataReader.GetString(1);
                    s.IndexNumber = sqlDataReader.GetString(2);
                    s.AverageMark = sqlDataReader.GetDecimal(3);

                    results.Add(s);
                }
            }


            return results;
        }

        public int InsertStudent(Student s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    String.Format("INSERT INTO Students VALUES { '{0}' '{1}' {2}) "
                    ,s.Name, s.IndexNumber, s.AverageMark);

                return sqlCommand.ExecuteNonQuery();
            }
        }


    }








}
 