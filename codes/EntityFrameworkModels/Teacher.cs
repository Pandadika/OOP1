using System;
using System.Collections.Generic;

namespace OOP1.codes.EntityFrameworkModels
{
    public partial class Teacher
    {
        public Teacher()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
