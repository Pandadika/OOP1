// See https://aka.ms/new-console-template for more information
// pat OOP1Token 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
using OOP1.codes;
using OOP1.codes.models;

//OOP1.codes.School s = new();

List<Student> Students = new(){
    new Student(1, "Martin", "Jensen"),
    new Student(2, "Patrik", "Nielsen"),
    new Student(3, "Susanne", "Hansen"),
    new Student(4, "Thomas", "Olsen")
};
List<Teacher> Teachers = new(){
    new Teacher(1, "Niels", "Olesen"),
    new Teacher(2, "Henrik", "Paulsen")
};
List<Course> Courses = new(){
    new Course(1, "Grundliggende programmering", 1),
    new Course(2, "Database programmering", 1),
    new Course(3, "Studieteknik", 1),
    new Course(4, "Clientside programmering", 2)
};
List<Enrollment> Enrollments = new();



Semester se = new("H1");
se.Name();

string? output;
string? input;


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
catch (System.Exception)
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

Enrollments.Add(new Enrollment(Enrollments.Count+1,StudentId,CourseId));

foreach (var enrollment in Enrollments)
{
    System.Console.WriteLine(enrollment.ToString());
}

