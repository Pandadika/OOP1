using System;

namespace OOP1.codes
{
    internal sealed class Semester : School
    {
        private string? SemesterNavn {get; set;}

        public Semester(string semesterName, string schoolName) : base(schoolName)
        {
            SemesterNavn = semesterName; 
            SchoolName = schoolName;
        }

        public string? GetSchoolName(){
            return SchoolName;
        }

        public string? GetSemesterName()
        {
            return SemesterNavn;
        }
    }

}
