using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double modLine = Math.Round(2.00 - 1.35, 2);
            double mod1 = Math.Round(modLine % 0.25, 2); 
            Console.WriteLine("modLine = " + modLine);
            Console.WriteLine("mod1 = " + mod1);
        }
    }
}