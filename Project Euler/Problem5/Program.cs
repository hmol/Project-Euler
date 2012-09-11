using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem5
{
    class Program
    {
        //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        static void Main(string[] args)
        {
            int answer = 0;
            bool isDiv = true;
            for (int i = 0; answer == 0; i += 2520)
            {
                isDiv = true;

                for (int j = 1; isDiv && j <= 20; j++)
                {
                    if (i % j != 0)
                        isDiv = false;
                }

                if (isDiv)
                    answer = i;
            }
            Console.WriteLine("answer:  {0}",answer);
            Console.ReadKey();
        }
    }
}
