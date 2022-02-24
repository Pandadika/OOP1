using System;
using OOP1.codes.models;

namespace OOP1.codes
{
    internal sealed class Semester : School
    {
        private string? SemesterNavn {get; set;}
        public int ProgrammeringsFagIAlt {get; set;}

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

        public override void SetCourseCount(List<Course> list)
        {
            FagIAlt = list.Count();
            int i = 0;
            foreach (var course in list)
            {
                if (course.CourseName.Contains("programmering"))
                {
                    i++;
                }
            }
            ProgrammeringsFagIAlt = i;
        }

    }

}
