using System;
using System.Collections.Generic;
using System.Linq;
using Shared;

namespace Euler
{
    public class Problem5
    {
        /* 
        
        https://projecteuler.net/problem=5

2520 is the smallest number that can be divided by each of the numbers
from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of
 the numbers from 1 to 20?
        */

        public static int FindSmallestNumberOfMultiplesUpTo(int limit) {
            var dict = new Dictionary<long, int>();
            var range = new EulerRange(2, limit);
            foreach(var item in range) {
                var primes = Helper.FindPrimeMultiples(item);
                foreach(var prime in primes) {
                    var cnt = primes.Count(x => x == prime);
                    if (!dict.ContainsKey(prime))
                        dict.Add(prime, 1);
                    if (dict[prime] < cnt)
                        dict[prime] = cnt; 
                }
            }
            var result = 1;
            foreach(var item in dict) {
                result*= (int)Math.Pow(item.Key, item.Value);
            }
            return result;
        }

    }
}

