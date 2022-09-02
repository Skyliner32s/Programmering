//Console.WriteLine("Hej NTI");
//Console.WriteLine("Hej TE21B");

string name;
string bodyPart;
string fluid;
string car;
//name = "Lucas";
//name = "Micke";

Console.WriteLine("Vad heter du?");
name = Console.ReadLine();

Console.WriteLine($"Välkommen {name}!");
Console.WriteLine("Skriv namnet på en kroppsdel");
bodyPart = Console.ReadLine();

Console.WriteLine("Skriv något flytande");
fluid = Console.ReadLine();

Console.WriteLine("Skriv ett bil märke");
car = Console.ReadLine();

Console.WriteLine($"{name} åker i en {car} gjord av {fluid} och han kör den med sin {bodyPart}");

Console.ReadLine();