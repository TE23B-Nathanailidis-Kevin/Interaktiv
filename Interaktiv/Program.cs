using System.Globalization;

Console.WriteLine("Du är i en skog");
Console.WriteLine("De finns två vägar, höger eller vänster.");
Console.WriteLine("Vilken väg väljer du, höger eller vänster?");
string vag = Console.ReadLine();

if (vag.ToLower() == "höger")
{
    Console.WriteLine("Du går höger och ser ett monster");
    Console.WriteLine("Vad gör du?");
    Console.WriteLine("Vill du attackera? [ja/nej]");
    string attackera = Console.ReadLine();

    if (attackera.ToLower() == "ja")
    {
        Console.WriteLine("Monstret äter upp dig");
        Console.ReadLine();
    }
    if (attackera.ToLower() == "nej")
    {
        Console.WriteLine("Du går iväg, halkar och bryter nacken");
        Console.ReadLine();
    }
}
if (vag.ToLower() == "vänster")
{
    Console.WriteLine("Du går vänster och ser ett stup");
    Console.WriteLine("Vill du hoppa över? [ja/nej]");
    string hoppa = Console.ReadLine();

    if (hoppa.ToLower() == "ja")
    {
        Console.WriteLine("du hoppar och klarar inte hoppet, så du dör av fallet");
        Console.ReadLine();
    }
    if (hoppa.ToLower() == "nej")
        Console.WriteLine("Monstret kommer och puttar ner dig");
    Console.ReadLine();
}
