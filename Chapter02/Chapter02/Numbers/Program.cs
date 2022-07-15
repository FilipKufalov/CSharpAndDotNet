
// unsigned integer means positive whole number or 0
uint naturalNumber = 23;

// integer means negative or positive whole number or 0
int integerNumber = -23;

// float means single-precision floating point
// F suffix makes it a float literal
float realNumber = 2.3F;

// double means double-precision floating point
// double literal
double anotherRealNumber = 2.3;

Console.WriteLine($"{naturalNumber}\n" +
    $"{integerNumber}\n" +
    $"{realNumber}\n" +
    $"{anotherRealNumber}");

Console.WriteLine($"int uses {sizeof(int)} bytes" +
    $"and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}");

Console.WriteLine($"double uses {sizeof(double)} bytes" +
    $"and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}");

Console.WriteLine($"decimal uses {sizeof(decimal)} bytes" +
    $"and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

Console.WriteLine("Using Doubles:");
double a = 0.1;
double b = 0.2;

Console.WriteLine($"{a} + {b} = {a + b}");

if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
}

Console.WriteLine("");
Console.WriteLine("Using Decimal:");
decimal c = 0.1M;
decimal d = 0.2M;

Console.WriteLine($"{c} + {d} = {c + d}");

if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3}");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equal {0.3}");
}

bool isBreak = false;
