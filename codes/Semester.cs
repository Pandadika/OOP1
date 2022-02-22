using System;

namespace OOP1.codes
{
    sealed class Semester : School
    {
        private string? SemesterNavn {get; set;}

        public Semester(string s)
        {
            SemesterNavn = s; 
        }

        public string? Name(){
            return SchoolName;
        }

        public string? Forloeb()
        {
            return SemesterNavn;
        }
    }

}
