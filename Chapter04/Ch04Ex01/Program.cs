using System;

namespace Ch04Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer");
            int myInt = Convert.ToInt32(Console.ReadLine());
            bool isLeesThan10 = myInt < 10;
            bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);
            Console.WriteLine($"Integer less than 10? {isLeesThan10}");
            Console.WriteLine($"Integer between 0 and 5? {isBetween0And5}");
            Console.WriteLine($"Exactly one of the above is true?" +
                $"{isLeesThan10 ^ isBetween0And5}");

            //Console.ReadKey();

            string myString = myInt < 10 ? "The number is less then 10" : "Greater then 10";
        }
    }
}
