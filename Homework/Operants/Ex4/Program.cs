using static System.Console;
int num1, num2;

try
{
    Write("Input the First Number: ");
    num1 = Convert.ToInt32(ReadLine());
    Write("Input the Second Number: ");
    num2 = Convert.ToInt32(ReadLine());
    WriteLine("Before Swapping");
    WriteLine($"First number: {num1}");
    WriteLine($"Second number: {num2}");
    (num1, num2) = (num2, num1);
    WriteLine("After Swapping");
    WriteLine($"First number: {num1}");
    WriteLine($"Second number: {num2}");
}
catch (Exception ex)
{
    Write(ex);
}
