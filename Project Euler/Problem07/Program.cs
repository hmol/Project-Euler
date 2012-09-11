using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem7
{
    class Program
    {
        //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        //What is the 10 001st prime number?
        static void Main(string[] args)
        {
            //Here my starting point is to generate a high number in which we are sure there are over 10001 primenumbers. 
            //Looking at the 4 first primes 2, 3, 5, 7, we see that 4^2 will generate a number(16) that is higher than the lagrest prime in the 
            //sequece (7). 
            //So I will here postulate that using the 2-power of the number of primes we want to find i.e: 10001^2, 
            //will generate a number in wich the range of primes will count higher than 10001. 
            //For this purpose, the algoritm of Eratosthenes is cool :-)
            int n = 10001;
            double powerd = Math.Round(Math.Pow(n, 2));
            int pow = int.Parse(powerd.ToString());
            bool[] b = SieveOfEratosthenes(pow);
            
            int i, primes;  primes = i = 0;
            do
            {
                if (b[++i])
                    primes++;
            }
            while (primes < n);

            Console.WriteLine("{0}", i);
            Console.ReadKey();
        }

        /// <summary>
        /// With the help of the Sieve Of Eratosthenes, generate all the primenumbers from 0 to the limit (n).
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool[] SieveOfEratosthenes(int n)
        {
            bool[] isPrime = new bool[n + 1];
            // initially assume all integers are prime
            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }

            // With the help of the Sieve of Eratosthenes values that is not prime is set to false 
            for (int i = 2; i * i <= n; i++)
            {
                // mark the multipples of i as false if i is prime
                if (isPrime[i])
                {
                    for (int j = i; i * j <= n; j++)
                        isPrime[i * j] = false;
                }
            }
            return isPrime;
        }
    }
}
