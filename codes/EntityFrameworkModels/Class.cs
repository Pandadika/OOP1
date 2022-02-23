using System;
using System.Collections.Generic;

namespace OOP1.codes.EntityFrameworkModels
{
    public partial class Class
    {
        public int? Course { get; set; }
        public int? Student { get; set; }

        public virtual Course? CourseNavigation { get; set; }
        public virtual Student? StudentNavigation { get; set; }
    }
}
