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
            Console.WriteLine("Choose a Option \n" + "1: FlipCoin Problem \n2: Perfect Number");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.Fibonacci();
                    break;
                case 2:
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.Perfect();
                    break;
                default:
                    Console.WriteLine("Please Choose a Correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
