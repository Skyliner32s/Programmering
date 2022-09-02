
//Läs in namnet
Console.WriteLine("Hello,What is your name");

string name = Console.ReadLine();

Console.WriteLine($"Hej {name}");

Console.WriteLine("Du rider din häst genom skogen ända tills du kommer fram till en korsning där du måste välja en väg, den första vägen ser murk och läskig, medans vid den andra skiner solen");
string option = Console.ReadLine();

if (option == "1")
{
    Console.WriteLine("");
}
else if (option == "2")
{
    Console.WriteLine("");
}
//Kolla om namnet är Lucas eller karl
if (name == "Lucas")
{
    Console.WriteLine("Du skrev in rätt namn");
}
else if (name == "karl")
{
    Console.WriteLine("varför karl?!?!");
}
else
{
    Console.WriteLine("Du skrev in fel namn");
}



Console.ReadLine();


//cr och cw shortcut