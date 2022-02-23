using System;
using System.Collections.Generic;

namespace OOP1.codes.EntityFrameworkModels
{
    public partial class Course
    {
        public Course()
        {
            Tests = new HashSet<Test>();
        }

        public int Id { get; set; }
        public string? CourseName { get; set; }
        public int? TeacherId { get; set; }

        public virtual Teacher? Teacher { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
    }
}
