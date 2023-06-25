using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter x:");
            int x = Convert.ToInt32(Console.ReadLine());
            calc(x);

        }//end main

        private  static void calc(int x)
        {
            double result = (Math.Pow(x, 2) + (2 * x) - 4);
            Console.WriteLine(result);

        }
    }
}
