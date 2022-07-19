using System;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInteger;
            string myString;
            myInteger = 17;
            myString = "\"myInteger\" is";
            Console.WriteLine($"{myString} {myInteger}");
            //Console.ReadKey();

            // Pi
            double PI = 22.0 / 7.0;
            Console.WriteLine(PI);

            int myInt;
            int myInt2;
            myInt2 = 4;

            myInt = +myInt2;
            Console.WriteLine(myInt);
        }
    }
}
