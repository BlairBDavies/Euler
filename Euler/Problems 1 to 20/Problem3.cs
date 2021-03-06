using System;
using System.Linq;
using Shared;

namespace Euler
{
    public static class Problem3
    {
        /* 
        
        The prime factors of 13195 are 5, 7, 13 and 29.

        What is the largest prime factor of the number 600851475143 ?

        */

        public static long FindLargestPrimeFactor(long num)
        {
            var current = 2L;
            var currentMax = 2L;
            while (num >= current)
            {
                if (num % current == 0 && Shared.Helper.IsPrime(current))
                {
                    num = num / current;
                    if (current > currentMax)
                        currentMax = current;

                    current = 2;
                    continue;
                }
                current++;
            }
            return currentMax;
        }

    }
}

