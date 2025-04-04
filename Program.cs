using coffee.tool.Data;

Console.WriteLine("Hello, World!");

Console.WriteLine("q for exit");
Console.WriteLine("h for help");


while (true)
{
    var command = Console.ReadLine();

    if (string.Equals("q", command, StringComparison.OrdinalIgnoreCase)) break;

    else { Console.WriteLine($"  it   is   er   {command} "); };
}

