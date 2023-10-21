// See https://aka.ms/new-console-template for more information

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var a in pallets)
{
    Console.WriteLine($"-- {a}");
}

Console.WriteLine("Reverse...");
Array.Reverse(pallets);
foreach (var s in pallets)
{
    Console.WriteLine($"{s}");
}


