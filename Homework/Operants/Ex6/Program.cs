using static System.Console;

int num1, num2;

Write("Input the first number: ");
num1 = Convert.ToInt32(ReadLine());
Write("Input the second number: ");
num2 = Convert.ToInt32(ReadLine());
WriteLine($"{num1} + {num2} = {num1 + num2}");
WriteLine($"{num1} - {num2} = {num1 - num2}");
WriteLine($"{num1} * {num2} = {num1 * num2}");
WriteLine($"{num1} / {num2} = {num1 / num2}");
WriteLine($"{num1} module {num2} = {num1 % num2}");
