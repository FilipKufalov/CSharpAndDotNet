using static System.Console;

int myNum = 12;

try
{
    WriteLine($"{myNum} / {0} = {myNum / 0}");
}
catch (Exception ex)
{
    WriteLine(ex.ToString());
}

double myDouble = 12.0;

try
{
    WriteLine($"{myDouble} / {0} = {myDouble / 0}");
}
catch (Exception ex)
{
    WriteLine(ex.ToString());
}

int intOverflow = 2147483647;

WriteLine($"Min value of int: {int.MinValue}");
WriteLine($"Max value of int: {int.MaxValue}");
WriteLine($"Overflow of int by one: {intOverflow + 1}");

int y, x; y = 5; x = y++;
WriteLine($"x = y++ is {x}", --y); x = ++y;
WriteLine($"x = ++y is {x}");

for (int i = 0; i < 3; i++)
{
    if (i == 2)
    {
        break;
    }
    WriteLine(i);
}

for (int i = 0; i < 3; i++)
{
    if (i == 2)
    {
        continue;
    }
    WriteLine(i);
}

for (int i = 0; i < 3; i++)
{
    if (i == 2)
    {
        //return;
    }
    WriteLine(i);
}

for (; ; )
{
    WriteLine("test");
    break;
}