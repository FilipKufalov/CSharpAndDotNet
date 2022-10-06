static int Factorial(int number)
{
    if (number<1)
    {
        return 0;
    }
    else if (number == 1)
    {
        return 1;
    }
    else
    {
        int returnVal = Factorial(number - 1);
        int res = number * returnVal;
        return res;
    }
}

static void RunFactorial()
{
    for (int i = 0; i < 15; i++)
    {
        Console.WriteLine($"{i}! = {Factorial(i):N0}");
    }
}

RunFactorial();