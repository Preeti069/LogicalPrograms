using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Logical Programs");
            Console.WriteLine("Choose a Option \n" + "1: FlipCoin Problem");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.Fibonacci();
                    break;
                default:
                    Console.WriteLine("Please Choose a Correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
