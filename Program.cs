// See https://aka.ms/new-console-template for more information
// pat OOP1Token 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
using OOP1.codes;
using OOP1.codes.models;




ADOHandler aDOHandler = new ADOHandler();
List<Teacher> listteachers = aDOHandler.GetTeacher();
foreach (var teacher in listteachers)
{
    Console.WriteLine(teacher.FirstnName);
}









//OPG initit something lol dårlig komment alligevel

List<Student> Students = new()
{
    new(1, "Martin", "Jensen"),
    new(2, "Patrik", "Nielsen"),
    new(3, "Susanne", "Hansen"),
    new(4, "Thomas", "Olsen")
};
List<Teacher> Teachers = new()
{
    new(1, "Niels", "Olesen"),
    new(2, "Henrik", "Paulsen")
};
List<Course> Courses = new()
{
    new(1, "Grundliggende programmering", 1),
    new(2, "Database programmering", 1),
    new(3, "Studieteknik", 1),
    new(4, "Clientside programmering", 2)
};

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

aDOHandler.InsertEnrollement(StudentId, CourseId);
List<object> Enrollments = aDOHandler.GetRecord(TECTables.Class);

foreach (var enrollment in Enrollments)
{
    System.Console.WriteLine(enrollment.ToString());
}

