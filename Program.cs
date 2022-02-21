// See https://aka.ms/new-console-template for more information

Console.WriteLine("This is arv");


//OOP1.codes.School s = new();

OOP1.codes.Semester se = new("H1");
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



