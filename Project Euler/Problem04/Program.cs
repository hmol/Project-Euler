using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem4
{
    class Program
    {
        //A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 99.
        //Find the largest palindrome made from the product of two 3-digit numbers.

        static void Main(string[] args)
        {
            int product, answer;
            product = answer = 0;

            for (int i = 999; i > 0; i--)
            {
                for (int j = 999; j > 0; j--)
                {
                    product = j * i;
                    if (isPalindrome(product) && product > answer)
                        answer = product;
                }
            }

            Console.Write("{0}", answer);
            Console.ReadKey();
        }

        /// <summary>
        /// Finds out if the input is a palindrome or not
        /// </summary>
        public static bool isPalindrome(int nr)
        {
            IEnumerable<char> revIE = nr.ToString().Reverse();
            string rev = string.Concat(revIE);
            return nr.ToString().Equals(rev);
        }
    }
}
