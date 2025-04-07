using coffee.tool.Data;
Console.WriteLine("-------------");
Console.WriteLine("Hello, World!");
Console.WriteLine("-------------");
Console.WriteLine("q for exit");
Console.WriteLine("h for help");

while (true)
{
    var command = Console.ReadLine();

    if (string.Equals("q", command, StringComparison.OrdinalIgnoreCase)) break;

    else { Console.WriteLine($"  it   is   er   {command} "); };
    if (string.Equals("h", command, StringComparison.OrdinalIgnoreCase)) Console.WriteLine("h for help");
    if (string.Equals("q", command, StringComparison.OrdinalIgnoreCase)) break;
    if (string.Equals("s", command, StringComparison.OrdinalIgnoreCase)) 
    { 
        var data =  new coffdataprovider(); 
        var coffeeshops = data.LoadShops();
        foreach (var coffeeshop in coffeeshops) { 
            Console.WriteLine(coffeeshop);
        }
    }
}

