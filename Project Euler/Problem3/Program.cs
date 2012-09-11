using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Problem3
{
    class Program
    {
        //The prime factors of 13195 are 5, 7, 13 and 29.
        //What is the largest prime factor of the number 600851475143 ?

        static void Main(string[] args)
        {

            long start = 600851475143;
            long startSqrt = long.Parse(Math.Round(Math.Sqrt(start), 0).ToString());

            bool finish = false;
            long answer = 0;

            for (; !finish && startSqrt > 1; startSqrt--)
            {
                if (start % startSqrt == 0) //do the number add up with 600851475143?
                {
                    if (isPrime(startSqrt))//if so, is it prime?
                    {
                        finish = true;
                        answer = startSqrt;
                    }
                }
            }

            Console.WriteLine("{0}", answer);
            Console.ReadKey();
        }

        /// <summary>
        /// Finds out if the input number is prime or not
        /// </summary>
        public static bool isPrime(long input)
        {
            long sqr = long.Parse(Math.Round(Math.Sqrt(input), 0).ToString());
            //we start with saying that the number is not prime
            bool notPrime = true;
            
            for (long j = sqr; notPrime && j > 1; j--)
            {
                if (input % j == 0)
                    notPrime = false;
            }

            return notPrime;
        }
    }
}
