// See https://aka.ms/new-console-template for more information
using OOP1.codes;

Console.WriteLine("This is arv");


//School s = new();

Semester se = new("H1", "TEC");

string? output;
string? input;


System.Console.WriteLine("Angiv Skole");
input = Console.ReadLine();
while(input.ToUpper() != se.Name()){
    System.Console.WriteLine("Skole findes ikke");
    System.Console.WriteLine("Angiv Skole");
    input = Console.ReadLine();
}
output = input+", ";
System.Console.WriteLine("Angiv Hovedforløb");
input = Console.ReadLine();
while(input.ToUpper() != se.Forloeb()){
    System.Console.WriteLine("Hovedforløb findes ikke");
    System.Console.WriteLine("Angiv Hovedforløb");
    input = Console.ReadLine();
}
output += input+" ";
output += "Fag tilmeldings app.";
System.Console.WriteLine(output);



