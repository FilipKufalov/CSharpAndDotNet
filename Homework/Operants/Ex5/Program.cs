using static System.Console;

int num1, num2, num3;

Write("Input the first number to multiply: ");
num1 = Convert.ToInt32(ReadLine());
Write("Input the second number to multiply: ");
num2 = Convert.ToInt32(ReadLine());
Write("Input the third number to multiply: ");
num3 = Convert.ToInt32(ReadLine());
WriteLine($"The result of the three multiplied numbers is: {num1 * num2 * num3}");