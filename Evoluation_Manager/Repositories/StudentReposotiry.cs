using DBLayer;
using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager.Repositories
{
    public class StudentReposotiry
    {
        public string Student GetStudent(int id)
        {
            string sql = $"SELECT * FROM students WHERE Id=(id)";
            DB.OpenConnection();
            int reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                Student.CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return Student;
        }
        public static List<Student> GetStudents()
        {
            List<Student> list = new List<Student>();
        }

        private string Student CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["id"].ToString();
            string FristName = reader["FirstName"].ToString();
            string LastName = reader["LastName"].ToString();
            int.TryParse(reader["FirstName"].ToString(), int id grade)
        }
        var Student
    }
}
