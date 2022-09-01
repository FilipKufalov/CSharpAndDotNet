Console.Write("Enter a number between 0 and 255: ");
try
{
    byte number = Convert.ToByte(Console.ReadLine());
    Console.Write($"Enter another number between 0 and 255: ");
    byte anothernumber = Convert.ToByte(Console.ReadLine());
    Console.Write($"{number} divided by {anothernumber} is {number / anothernumber}");
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}