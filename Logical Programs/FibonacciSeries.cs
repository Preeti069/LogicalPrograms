using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    public class FibonacciSeries
    {
        public void Fibonacci()
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int n1 = 0, n2 = 1, n3 = 0;
            Console.WriteLine(n1 + "\n" + n2 + " ");
            for (int i = 2; i < num; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();
        }
    }
}
