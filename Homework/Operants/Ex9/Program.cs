using static System.Console;

int num1, num2, num3;

Write("Enter first number: ");
num1 = Convert.ToInt32(ReadLine());
Write("Enter second number: ");
num2 = Convert.ToInt32(ReadLine());
Write("Enter third number: ");
num3 = Convert.ToInt32(ReadLine());
WriteLine($"Result of specified numbers {num1},{num2} and {num3}: (x+y)*z is {(num1 + num2)*num3} and {num1} * {num2} + {num2} * {num3} is {num1 * num2 + num2 * num3}");