using OOP1.codes.models;
using System.Data.SqlClient;

namespace OOP1.codes
{
    internal class ADOHandler
    {
        public string ConnectionString
        {
            get => "Data Source=DESKTOP-T3AT079;Initial Catalog=TEC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }


        public List<Teacher> GetTeacher()
        {
            List<Teacher> list = new List<Teacher>();

            using SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Teacher", con);

            SqlDataReader reader = command.ExecuteReader();
            
            while(reader.Read())
            {
                Teacher teacher = new(reader.GetInt32(0),reader.GetString(1),reader.GetString(2));
                list.Add(teacher);
            }
            return list;
        }

        public List<Student> GetStudents()
        {
            List<Student> list = new List<Student>();

            using SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Student", con);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Student student = new(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                list.Add(student);
            }
            return list;
        }

        public List<Course> GetCourses()
        {
            List<Course> list = new List<Course>();

            using SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Course", con);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Course course = new(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
                list.Add(course);
            }
            return list;
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
