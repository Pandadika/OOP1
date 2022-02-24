using System;

namespace OOP1.codes
{
    sealed class Semester : School
    {
        private string? SemesterName { get; set; }

        public Semester(string semesterName, string schoolName) : base (schoolName)
        {
            SemesterName = semesterName;
        }

        public string? GetSchoolName()
        {
            return base.SchoolName;
        }

        public string? GetSemesterNavn()
        {
            return SemesterName;
        }
    }

}
