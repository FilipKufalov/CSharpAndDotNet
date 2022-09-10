using static System.Console;

int num1, num2, num3, num4;

Write("Input the first: ");
num1 = Convert.ToInt32(ReadLine());
Write("Input the second: ");
num2 = Convert.ToInt32(ReadLine());
Write("Input the third: ");
num3 = Convert.ToInt32(ReadLine());
Write("Input the four: ");
num4 = Convert.ToInt32(ReadLine());
WriteLine($"The average of {num1}, {num2}, {num3}, {num4} is {(num1+num2+num3+num4)/4}");