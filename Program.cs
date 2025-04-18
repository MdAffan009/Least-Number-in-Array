using System;

namespace LeastNumInArr
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] num = { 8, 5, 10, 9, 7, 2 };

            int minInt = num.Min();

            Console.WriteLine(minInt);


            Console.ReadKey();
        }
    }
}