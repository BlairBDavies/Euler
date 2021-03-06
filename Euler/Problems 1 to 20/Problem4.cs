using System;
using System.Collections.Generic;
using System.Linq;
using Shared;

namespace Euler
{
    public class Problem4
    {
        /* 
        
        https://projecteuler.net/problem=4
        A palindromic number reads the same both ways. 
        The largest palindrome made from the product of 
        two 2-digit numbers is 9009 = 91 × 99.

        Find the largest palindrome made from the 
        product of two 3-digit numbers.   
        */

        public int FindLargestPalindrome(int numDigits)
        {
            return OptimizationAttempt1(numDigits);
            //return BruteForce(numDigits);
        }

        private int BruteForce(int numDigits)
        {
            var range = new EulerRange((int)Math.Pow(10, numDigits - 1), (int)Math.Pow(10, numDigits) - 1);
            var numbers = new List<(int left, int right, int total)>();
            //Get every multiple
            foreach (var item in range)
            {
                numbers.AddRange(range.Select(x => (x, item, item * x)));
            }

            foreach (var item in numbers.OrderByDescending(x => x.total))
            {
                if (NumberStringHelper.IsNumberPalindrome(item.total))
                {
                    return item.total;
                }
            }

            return -1;
        }


        private int OptimizationAttempt1(int numDigits)
        {
            if (numDigits == 1) return 9;

            var upperLimit = (int)Math.Pow(10, numDigits) - 1;
            var lowerLimit = upperLimit - (int)Math.Pow(10, numDigits - 1);

            var range = new EulerRange(lowerLimit, upperLimit);
            HashSet<int> numbers = new HashSet<int>();
            //Get every multiple
            foreach (var item in range)
            {
                range.Select(x => numbers.Add(item * x)).ToList();
            }

            foreach (var item in numbers.OrderByDescending(x => x))
            {
                if (NumberStringHelper.IsNumberPalindrome(item))
                {
                    return item;
                }
            }
            return -1;
        }

    }
}

