using static System.Console;

try
{
    Write("Type any number: ");
    int num1 = Convert.ToInt32(ReadLine());
    Write("Type another number: ");
    int num2 = Convert.ToInt32(ReadLine());
    WriteLine($"The sum of first and second number is {num1 + num2}");
}
catch (Exception ex)
{
    Write(ex);
}
