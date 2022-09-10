// See https://aka.ms/new-console-template for more information
Console.Write("Enter the amount of Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Kelvin = {celsius + 273}");
Console.WriteLine($"fahrenheit = {(celsius * 9.0 / 5.0) + 32}");

