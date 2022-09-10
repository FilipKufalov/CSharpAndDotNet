Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= num; i++)
{
    if (i == 0 || i == num)
    {
        Console.WriteLine($"{num}{num}{num}");
    } else if (num > 9)
    {
        Console.WriteLine($"{num}  {num}");
    }
    else
    {
        Console.WriteLine($"{num} {num}");
    }
}