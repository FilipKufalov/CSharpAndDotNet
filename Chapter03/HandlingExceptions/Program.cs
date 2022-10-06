Console.WriteLine("Before parsing");
Console.Write("What is your age?");
string? input = "Kermit";

try
{
    int age = int.Parse(input);
    Console.WriteLine($"You are {age} years old");
}
catch (Exception)
{
}
Console.WriteLine("After parsing");