#region Usings

#endregion

#region MainMethod

string comprasion;
Console.WriteLine("Enter a number:");
double var1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter another number:");
double var2 = Convert.ToDouble(Console.ReadLine());
if (var1 < var2)
    comprasion = " less than ";
else
{
    if (var1 == var2)
        comprasion = " equal to ";
    else 
        comprasion = " greater than ";

}
Console.WriteLine(var1 + comprasion + var2);

#endregion