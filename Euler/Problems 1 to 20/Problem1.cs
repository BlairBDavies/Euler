using System;
using System.Linq;

namespace Euler
{
    public class Problem1
    {
        /* 
        
        If we list all the natural numbers below 10
        that are multiples of 3 or 5, we get 3, 5, 
        6 and 9. The sum of these multiples is 23.

        Find the sum of all the multiples of 3 or 5 below 1000.

        */

        public static int SumOfMultiples(int maximum = 1000)
        {
            if (maximum < 3) return 0;

            maximum--;

            return Enumerable.Range(1, maximum / 3).Select(x => x * 3).Union(
                Enumerable.Range(1, maximum / 5).Select(x => x * 5)).Distinct().Sum();
        }
    }
}
