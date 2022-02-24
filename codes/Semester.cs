using System;

namespace OOP1.codes
{
    sealed class Semester : School
    {
        private string? SemesterNavn {get; set;}

        public Semester(string semesterName, string schoolName) : base(schoolName)
        {
            SemesterNavn = semesterName; 
            SchoolName = schoolName;

        }

        public string? Name(){
            return base.SchoolName;
        }

        public string? Forloeb()
        {
            return SemesterNavn;
        }
    }

}
