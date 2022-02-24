// Iteration 7
using OOP1.codes;
using OOP1.codes.models;


List<Course> Courses = new(){
    new() { Id = 1, CourseName = "Grundliggende programmering" , TeacherId = 1},
    new() { Id = 2, CourseName = "Database programmering", TeacherId = 1},
    new() { Id = 3, CourseName = "Studieteknik", TeacherId = 1},
    new() { Id = 4, CourseName = "Clientside programmering", TeacherId = 2}
};

Semester semester = new("H1", "TEC");


Console.WriteLine("Usorteret Liste\n------------------------");
foreach (var course in Courses)
{
    Console.WriteLine($"{course.Id}: {course.CourseName}");
}

Console.WriteLine("\nAlfabetisk sorteret\n------------------------");
Courses.Sort();
foreach (var course in Courses)
{
    Console.WriteLine($"{course.Id}: {course.CourseName}");
}
Courses.Reverse();
Console.WriteLine("\nReverse Alfabetisk sorteret\n------------------------");
foreach (var course in Courses)
{
    Console.WriteLine($"{course.Id}: {course.CourseName}");
}
Console.WriteLine("\nICompare Id sorteret\n------------------------");
Courses.Sort(new CourseIdComperer());
foreach (var course in Courses)
{
    Console.WriteLine($"{course.Id}: {course.CourseName}");
}