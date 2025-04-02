// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("q");
Console.WriteLine("for exit");
while (true)
{
    var command = Console.ReadLine();
    if (string.Equals("q",command,StringComparison.OrdinalIgnoreCase)) break;
}
