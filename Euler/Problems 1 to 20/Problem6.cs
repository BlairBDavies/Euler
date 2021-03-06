using System;
using System.Linq;

namespace Euler
{
    public class Problem6
    {
        /* 
        
        https://projecteuler.net/problem=6
The sum of the squares of the first ten natural numbers is,

12+22+...+102=385
The square of the sum of the first ten natural numbers is,

(1+2+...+10)2=552=3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025−385=2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        */
        public static int FindDifference(int limit)
        {
            return FindSquareOfSum(limit) - FindSumOfSquares(limit);
        }

        public static int FindSumOfSquares(int limit)
        {
            var sum = 0;
            for (int i = 1; i <= limit; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        public static int FindSquareOfSum(int limit)
        {
            var sum = 0;
            for (int i = 1; i <= limit; i++)
            {
                sum += i;
            }
            return sum * sum;
        }
    }
}

