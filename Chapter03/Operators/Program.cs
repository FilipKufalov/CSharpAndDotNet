using static System.Console;

int a = 5;
int b = a++;
WriteLine($"\"a\" is {a}, \"b\" is {b}");

int c = 3;
int d = ++c;
WriteLine($"\"c\" is {c}, \"d\" is {d}");