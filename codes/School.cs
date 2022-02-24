using System;
using OOP1.codes.models;

namespace OOP1.codes
{
    internal abstract class School
    {
        protected string? SchoolName {get; set;}
        public int FagIAlt { get; set;}
        public School(string s)
        {
            SchoolName = s;
        }

        public virtual void SetCourseCount(List<Course> list)
        {
            FagIAlt = list.Count();
        }


    }
}
