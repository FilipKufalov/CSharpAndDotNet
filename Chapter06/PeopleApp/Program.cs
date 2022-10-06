using PeopleLib;
using static System.Console;

Person harry = new() { Name = "Harry" };
Person mary = new() { Name = "Mary" };
Person jill = new() { Name = "Jill" };
// call instance method
Person baby1 = mary.ProcreateWith(harry);
baby1.Name = "Gary";
// call static method
Person baby2 = Person.Procreate(harry, jill);
WriteLine($"{harry.Name} has {harry.Children.Count} children.");
WriteLine($"{mary.Name} has {mary.Children.Count} children.");
WriteLine($"{jill.Name} has {jill.Children.Count} children.");
WriteLine(
 format: "{0}'s first child is named \"{1}\".",
 arg0: harry.Name,
 arg1: harry.Children[0].Name);

//Person baby2 = Person.Procreate(harry, jill);
Person baby3 = harry * mary;
Console.WriteLine(baby3.Children);

WriteLine($"5! is {Person.Factorial(5)}");
WriteLine($"3 + 4 = {Person.Add(3, 4)}");
int math4 = Person.Add(10, 15);
Console.WriteLine(math4);
