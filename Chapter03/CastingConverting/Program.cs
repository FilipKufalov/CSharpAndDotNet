using static System.Console;
using static System.Convert;

int a = 10;
double b = a;
WriteLine($"int a = 10 convert to double = {b}");

double c = 9.8;
int d = (int)c;
WriteLine($"double c = {c} convert to int = {d}");

long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");
e = long.MaxValue;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

double g = 9.8;
int h = (int)g;
WriteLine($"Using explicit int convert {h}");
h = ToInt32(g);
WriteLine($"Using ToInt Converter: {h}");


