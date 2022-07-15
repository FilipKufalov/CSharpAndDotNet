using System.Xml;

object height = 1.88;
object name = "Amir";
Console.WriteLine($"{name} is {height} metres tall.");

//int length1 = name.Length; // gives compile error!
int length2 = ((string)name).Length;
Console.WriteLine($"{name} is {length2} metres tall.");

var xml1 = new XmlDocument();
XmlDocument xm2 = new XmlDocument();

var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

string[] names = new[] { "Kate", "Jack", "Rebecca", "Tom" };

for (int i = 0; i < names.Length; i++)
    {
    Console.WriteLine(names[i]);
}