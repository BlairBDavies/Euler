using System;
using System.Linq;

namespace Euler
{
    public class Problem7
    {
        /* 
        
        https://projecteuler.net/problem=7
By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number?
        */
        public static long FindNthPrime(int location) {
            var prime = 1L;
            for(int i = 1; i <= location; i++) {
                prime = Shared.Helper.GetNextPrime(prime);
            }
            return prime;
        }
    }
}

