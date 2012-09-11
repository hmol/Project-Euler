using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem6
{
    class Program
    {
        //The sum of the squares of the first ten natural numbers is, 1^2 + 2^2 + ... + 10^2 = 385
        //The square of the sum of the first ten natural numbers is, (1 + 2 + ... + 10)^2 = 55^2 = 3025
        //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 - 385 = 2640.
        //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        static void Main(string[] args)
        {
            double sum1, sum2;
            sum1 = sum2 = 0;

            for (int i = 1; i <= 100; i++)
            {
                sum1 += Math.Pow(i,2);
                sum2 += i;
            }

            sum2 = Math.Pow(sum2, 2);

            Console.WriteLine("{0}",sum2-sum1);
            Console.ReadKey();
        }
    }
}
