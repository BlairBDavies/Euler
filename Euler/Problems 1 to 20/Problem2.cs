using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler
{
    public class Problem2
    {
        /*         
        https://projecteuler.net/problem=2
        Each new term in the Fibonacci sequence is generated 
        by adding the previous two terms. By starting with 1 and 2, 
        the first 10 terms will be:
        
        1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
        
        By considering the terms in the Fibonacci sequence whose 
        values do not exceed four million, find the sum of the 
        even-valued terms.
        */

        private List<int> fibonacci = new List<int>() { 2, 1 };

        public Problem2()
        {
            while (fibonacci[0] < 4000000)
            {
                fibonacci.Insert(0, fibonacci[0] + fibonacci[1]);
            }
        }

        public int SumEvenFibonacciUnder(int max = 4000000)
        {
            return this.fibonacci.Where(x => (x % 2) == 0 && x < max).Sum();
        }
    }
}

