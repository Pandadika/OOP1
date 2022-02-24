using System;

namespace OOP1.codes
{
    abstract class School
    {
        protected string? SchoolName {get; set;}
        public School(string schoolName)
        {
            SchoolName = schoolName;
        }


    }
}
