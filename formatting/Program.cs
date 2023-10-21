
// Composite Formatting
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

// string interpolation
string first2 = "Hello";
string second2 = "World";
Console.WriteLine($"{first2} {second2}!");
Console.WriteLine($"{second2} {first}!");
Console.WriteLine($"{first2} {first2} {first2}!");

// Formatting currency
decimal price = 123.45m;
decimal discount = 50.0m;
// :C = $
Console.WriteLine($"Price: {price:C} (Save {discount:C})");