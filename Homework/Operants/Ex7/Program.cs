using static System.Console;

Write("Input the number and get multiplication table: ");
int num1 = Convert.ToInt32(ReadLine());
for (int i = 0; i <= 10; i++)
{
    WriteLine($"{num1} * {i} = {num1 * i}");
}