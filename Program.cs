// See https://aka.ms/new-console-template for more information
// pat OOP1Token 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
using OOP1.codes;
using OOP1.codes.models;


List<Student> Students = new(){
    new() { Id = 1, FirstName = "Martin", LastName = "Jensen"},
    new() { Id = 2, FirstName = "Patrik", LastName = "Nielsen" },
    new() { Id = 3, FirstName = "Susanne", LastName = "Hansen" },
    new() { Id = 4, FirstName = "Thomas", LastName = "Olsen" },
};
List<Teacher> Teachers = new(){
    new() { Id = 1, FirstName = "Niels", LastName = "Olesen" },
    new() { Id = 2, FirstName = "Henrik", LastName = "OlePaulsensen" }
};
List<Course> Courses = new(){
    new() { Id = 1, CourseName = "Grundliggende programmering" , TeacherId = 1},
    new() { Id = 2, CourseName = "Database programmering", TeacherId = 1},
    new() { Id = 3, CourseName = "Studieteknik", TeacherId = 1},
    new() { Id = 4, CourseName = "Clientside programmering", TeacherId = 2}
};
List<Enrollment> Enrollments = new();



//School s = new();
Semester se = new("H1");

string? output;
string input;


System.Console.WriteLine("Angiv Skole");
input = Console.ReadLine();
while(input != se.Name()){
    System.Console.WriteLine("Skole findes ikke");
    System.Console.WriteLine("Angiv Skole");
    input = Console.ReadLine();
}
output = input+", ";
System.Console.WriteLine("Angiv Hovedforløb");
input = Console.ReadLine();
while(input != se.Forloeb()){
    System.Console.WriteLine("Hovedforløb findes ikke");
    System.Console.WriteLine("Angiv Hovedforløb");
    input = Console.ReadLine();
}
output += input+" ";
output += "Fag tilmeldings app.";
System.Console.WriteLine(output);

System.Console.WriteLine("Indtast elev");
input = Console.ReadLine();
int inputId;

try
{
    inputId = Int32.Parse(input);
}
catch (System.Exception)
{
    System.Console.WriteLine("Student findes ikke");
    throw;
}

int StudentId = 0;
foreach (var student in Students)
{
    if (student.Id == inputId)
    {
        StudentId = inputId;
    }
}


System.Console.WriteLine("Indtast Course");
input = Console.ReadLine();
try
{
    inputId = Int32.Parse(input);
}
catch (System.Exception e)
{
    System.Console.WriteLine("Course findes ikke");
    throw;
}
int CourseId = 0;
foreach (var course in Courses)
{
    if (course.Id == inputId)
    {
        CourseId = inputId;
    }
}

Enrollments.Add(new Enrollment() { Id = Enrollments.Count()+1, CourseId = CourseId, StudentId = StudentId});

foreach (var enrollment in Enrollments)
{
    System.Console.WriteLine(enrollment.ToString());
}

