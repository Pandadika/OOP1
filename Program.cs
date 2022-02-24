// See https://aka.ms/new-console-template for more information
// pat OOP1Token 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
using OOP1.codes;
using OOP1.codes.EntityFrameworkModels;
using OOP1.codes.EntityFramework_Eksample;




EntityFrameworkHandler en = new EntityFrameworkHandler();
List<Student> students = en.GetStudents();
List<Course> courses = en.GetCourses();
List<Teacher> teachers = en.GetTeacher();
en.ClearEnrollement();

Semester semester = new("H1", "TEC");

string? output;
string? input;


// LOGIN

System.Console.WriteLine("Angiv Skole");
input = Console.ReadLine();
while (input.ToUpper() != semester.GetSchoolName().ToUpper())
{
    System.Console.WriteLine("Skole findes ikke");
    System.Console.WriteLine("Angiv Skole");
    input = Console.ReadLine();
}
output = input.ToUpper() + ", ";
System.Console.WriteLine("Angiv Hovedforløb");
input = Console.ReadLine();
while (input.ToUpper() != semester.GetSemesterName().ToUpper())
{
    System.Console.WriteLine("Hovedforløb findes ikke");
    System.Console.WriteLine("Angiv Hovedforløb");
    input = Console.ReadLine();
}

Console.WriteLine("Angiv linje");
string linje = Console.ReadLine();
semester.SetUddanelselinje(linje);

output += semester.GetUddanelselinje() + ", ";
output += input.ToUpper() + " ";
output += "Fag tilmeldings app.";


// MENU
while (true)
{
resetMenu:
    Console.Clear();
    Console.WriteLine("------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.Green;
    System.Console.WriteLine(output);
    if (semester.GetUddanelselinjeBeskrivelse() != null && semester.GetUddanelselinjeBeskrivelse() != string.Empty)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"[   {semester.GetUddanelselinjeBeskrivelse()}   ]");
    }
    Console.ResetColor();
    Console.WriteLine("------------------------------------------------------\n");
    if (semester.GetUddanelselinjeBeskrivelse() == null)
    {
        Console.WriteLine("\n Ønsker du at angive uddanelse beskrivelse?\n1) Ja\n2) Nej\nVælg 1 eller 2:");
        input = Console.ReadLine();
        int result;
        while (!Int32.TryParse(input, out result) || !(result == 1 || result == 2))
        {
            Console.WriteLine("Prøv igen");
            input = Console.ReadLine();
        }
        switch (result)
        {
            case 1:
                Console.WriteLine("Skriv beskrivelse");
                input = Console.ReadLine();
                semester.SetUddanelselinje(semester.GetUddanelselinje(), input);
                goto resetMenu;
            case 2:
                semester.SetUddanelselinje(semester.GetUddanelselinje(), "");
                goto resetMenu;
            default:
                break;
        }
    }

    List<Class> Enrollements = en.GetClasses();
    int progElever = 0, dataElever = 0, serverElever = 0;
    foreach (var enrollment in Enrollements)
    {
        if (enrollment.Course == 1)
        {
            progElever++;
        }
        else if (enrollment.Course == 2)
        {
            dataElever++;
        }
        else if (enrollment.Course == 3)
        {
            serverElever++;
        }

    }
    Console.WriteLine($"{progElever} i Grundliggende Programmering");
    Console.WriteLine($"{dataElever} i Database Programmering");
    Console.WriteLine($"{serverElever} i Server Programmering");
    AddStudent();

}

void AddStudent()
{




    System.Console.WriteLine("Indtast elev");
    int inputId = 0;

    input = Console.ReadLine();
    try
    {
        inputId = Int32.Parse(input);
    }
    catch (System.Exception)
    {
        System.Console.WriteLine("Student id skal være et tal");
        Console.ReadLine();
        return;
    }

    int StudentId = 0;
    foreach (var student in students)
    {
        if (student.Id == inputId)
        {
            StudentId = inputId;
        }
    }
    if (StudentId == 0)
    {
        Console.WriteLine("Student id findes ikke!");
        Console.ReadLine();
        return;
    }



    System.Console.WriteLine("Indtast Course");
    input = Console.ReadLine();
    try
    {
        inputId = Int32.Parse(input);
    }
    catch (System.Exception)
    {
        System.Console.WriteLine("Course id er tal");
        Console.ReadLine();
        return;
    }
    int CourseId = 0;
    foreach (var course in courses)
    {
        if (course.Id == inputId)
        {
            CourseId = inputId;
        }
    }
    if  (CourseId == 0)
    {
        Console.WriteLine("Course id findes ikke!");
        Console.ReadLine();
        return;
    }



    List<Class> enrollments = en.GetClasses();
    bool contain = false;
    foreach (var enrollment in enrollments)
    {
        if (enrollment.Student == StudentId && enrollment.Course == CourseId)
        {
            Console.WriteLine("Course already contains student");
            Console.ReadLine();
            contain = true;
        }
    }
    if (!contain)
    {
        en.InsertEnrollement(StudentId, CourseId);
    }
}