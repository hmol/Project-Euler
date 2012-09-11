using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem10
{
    //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    //Find the sum of all the primes below two million.
    class Program
    {
        //Once again I will use the brilliant Sieve :)
        static void Main(string[] args)
        {
            int n = 2000000;
            bool[] b = SieveOfEratosthenes(n); 
            long sum = 0;

            for (long i = 2; i < b.Length; i++)
                if (b[i])
                    sum += i;

            Console.WriteLine("{0}", sum);
            Console.ReadKey();
        }

        /// <summary>
        /// With the help of the Sieve Of Eratosthenes, generate all the primenumbers from 0 to the limit (n).
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool[] SieveOfEratosthenes(int n)
        {
            bool[] isPrime = new bool[n];
            // initially assume all integers are prime
            for (int i = 2; i < n; i++)
            {
                isPrime[i] = true;
            }

            // With the help of the Sieve of Eratosthenes values that is not prime is set to false 
            for (int i = 2; i * i < n; i++)
            {
                // mark the multipples of i as false if i is prime
                if (isPrime[i])
                {
                    for (int j = i; i * j < n; j++)
                        isPrime[i * j] = false;
                }
            }
            return isPrime;
        }
    }
}
