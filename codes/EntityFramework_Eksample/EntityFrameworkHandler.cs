using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP1.codes.EntityFrameworkModels;

namespace OOP1.codes.EntityFramework_Eksample
{
    internal class EntityFrameworkHandler
    {
        public List<Teacher> GetTeacher()
        {
            TECContext db = new();
            return db.Teachers.ToList();
        }

        public List<Student> GetStudents()
        {
            TECContext db =new();
            return db.Students.ToList();
        }

        public List<Course> GetCourses()
        {
            TECContext db = new();
            
            return db.Courses.ToList();
        }

        public void InsertEnrollement(int studentid, int courseid)
        {
            using SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand($"INSERT INTO Enrollment VALUES({studentid},{courseid})", con);

            command.ExecuteNonQuery();

        }
    }
}
