﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem9
{
    //A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
    //a^2 + b^2 = c^2
    //For example, 3^2 + 4^2 = 9 + 16 = 25 = 52.
    //There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc.
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c; a = b = c = 0;
            bool loop = true;
            
            for (int x = 0; loop; x++)
            {
                for (int y = 0; y < x && loop; y++)
                {
                    a = Math.Pow(x, 2) - Math.Pow(y, 2);
                    b = 2 * x * y;
                    c = Math.Pow(x, 2) + Math.Pow(y, 2);

                    loop = !(a + b + c == 1000 && Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2));
                }
            }
            
            Console.WriteLine("{0}", a * b * c);
            Console.ReadKey();
        }
    }
}
