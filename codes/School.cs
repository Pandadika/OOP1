using System;

namespace OOP1.codes
{
    internal abstract class School
    {
        protected string? SchoolName {get; set;}

        public abstract string? Uddanelseslinje { get; set;}

        public abstract string? UddanelseslinjeBeskrivelse { get; set; }

        public School(string schoolName)
        {
            SchoolName = schoolName;
        }

        public abstract void SetUddanelselinje(string uddannelselinje);
    }
}
