using System;
using System.Collections.Generic;

namespace OOP1.codes.EntityFrameworkModels
{
    public partial class Test
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? CourseId { get; set; }

        public virtual Course? Course { get; set; }
    }
}
