using System;

namespace OOP1.codes.models

{
    internal class Course : IComparable<Course>
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public int TeacherId { get; set; }

        public int CompareTo(Course other)
        {
            return CourseName.CompareTo(other.CourseName);
        }

    }

    class CourseIdComperer : IComparer<Course>
    {
        public int Compare(Course? x, Course? y)
        {
            return x.Id.CompareTo(y.Id);
        }
    }

}
