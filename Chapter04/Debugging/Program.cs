using static System.Console;

static double Add(double a, double b)
{
    return a * b; // deliberate bug! 
	// function is called Add but we use Multiply operator
}