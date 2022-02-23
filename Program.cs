// See https://aka.ms/new-console-template for more information
// pat OOP1Token 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
using OOP1.codes;

using OOP1.codes.EntityFrameworkModels;
using OOP1.codes.EntityFramework_Eksample;




EntityFrameworkHandler en = new EntityFrameworkHandler();
List<Student> students = en.GetStudents();
List<Course> courses = en.GetCourses();
List<Teacher> teachers = en.GetTeacher();


//School s = new();
Semester se = new("H1");

string? output;
string? input;


System.Console.WriteLine("Angiv Skole");
input = Console.ReadLine();
while (input != se.Name())
{
    System.Console.WriteLine("Skole findes ikke");
    System.Console.WriteLine("Angiv Skole");
    input = Console.ReadLine();
}
output = input + ", ";
System.Console.WriteLine("Angiv Hovedforløb");
input = Console.ReadLine();
while (input != se.Forloeb())
{
    System.Console.WriteLine("Hovedforløb findes ikke");
    System.Console.WriteLine("Angiv Hovedforløb");
    input = Console.ReadLine();
}
output += input + " ";
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
foreach (var student in students)
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
foreach (var course in courses)
{
    if (course.Id == inputId)
    {
        CourseId = inputId;
    }
}

en.InsertEnrollement(StudentId, CourseId);
List<Class> Enrollments = en.GetClasses();
