using OOP1Opgave1.codes;


Box lilleBox = new Box();
Box lilleBox2 = new Box(2.3,2.5,2.2);
Box toSmåBoxes = lilleBox + lilleBox2;
Box mediumBox = new Box(2,3,4);
Box storBox = mediumBox * toSmåBoxes;

List<Box> boxes = new() { lilleBox, lilleBox2, toSmåBoxes, mediumBox, storBox };

foreach (var box in boxes)
{
    Console.WriteLine(box.ToString());
}

Console.WriteLine("\nBoxes sorteret efter volume");

boxes.Sort();
foreach (var box in boxes)
{
    Console.WriteLine("Volume: " + Math.Round(box.GetVolume(),2)+ " " +box.ToString());
}