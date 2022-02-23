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
            using TECContext db = new();
            return db.Teachers.ToList();
        }

        public List<Student> GetStudents()
        {
            using TECContext db =new();
            return db.Students.ToList();
        }

        public List<Course> GetCourses()
        {
            using TECContext db = new();
            
            return db.Courses.ToList();
        }

        public void InsertEnrollement(int studentid, int courseid)
        {
            using TECContext db = new();
            Class enrollment = new() { Student = studentid, Course = courseid };
    
            db.Add(enrollment);
            db.SaveChanges();

        }
    }
}
