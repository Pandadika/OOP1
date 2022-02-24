using System;

namespace OOP1.codes
{
    internal sealed class Semester : School
    {
        private string? SemesterName { get; set; }
        public override string? Uddanelseslinje { get; set; }
        public override string? UddanelseslinjeBeskrivelse { get; set; }

        public Semester(string semesterName, string schoolName) : base (schoolName)
        {
            SemesterName = semesterName;
        }

        public override void SetUddanelselinje(string uddannelselinje)
        {
            Uddanelseslinje = uddannelselinje;
        }

        public void SetUddanelseslinje(string uddanelseslinje, string uddanelsesbeskrivelse)
        {
            Uddanelseslinje = uddanelseslinje;
            UddanelseslinjeBeskrivelse = uddanelsesbeskrivelse;
        }

        public string? GetSchoolName()
        {
            return base.SchoolName;
        }

        public string? GetSemesterName()
        {
            return SemesterName;
        }

        public string? GetUddanelselinje()
        {
            return Uddanelseslinje;
        }
    }

}
