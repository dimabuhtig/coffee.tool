internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine("q");
        Console.WriteLine("for exit");
        while (true)
        {
            var command = Console.ReadLine();
            if (string.Equals("q", command, StringComparison.OrdinalIgnoreCase)) break;
            else { Console.WriteLine($"  it   is   er   {command} "); };
        }
    }
}