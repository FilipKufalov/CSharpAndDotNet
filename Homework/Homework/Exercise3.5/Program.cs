using System;

namespace Exercise3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(args[0]);
            int num2 = int.Parse(args[1]);
            int num3 = int.Parse(args[2]);
            int num4 = int.Parse(args[3]);

            if (args.Length != 4)
            {

                Console.WriteLine("Missing some arguments, Min & Max arguments = 4");
            } else
            {
                double t = Convert.ToDouble(Calc4Numbers(num1,num2,num3,num4));
                Console.WriteLine(t);
            }
        }

        static int Calc4Numbers(int num1, int num2, int num3, int num4)
        {
            return num1 + num2 + num3 + num4;
        }
    }
}
