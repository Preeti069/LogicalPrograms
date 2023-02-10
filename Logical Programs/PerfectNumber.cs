using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class PerfectNumber
    {
        public void Perfect()
        {
            Console.WriteLine("Enter a number to Check Perfect or Not");
            int Num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i < Num; i++)
            {
                if (Num % i == 0)
                {
                    sum = sum + i;
                    Console.WriteLine("\n{0}", i);
                }
            }
            Console.WriteLine("The Sum of Divisors is : " + sum);
            if (sum == Num)
            {
                Console.ForegroundColor = ConsoleColor.Green;  //below statment shows in Green color
                Console.WriteLine("Given Number is Perfect Number");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;    //below statment shows in Red color
                Console.WriteLine("The Given Number iS Not a Perfect NUmber");
            }
            Console.ReadLine();
        }
    }
}
