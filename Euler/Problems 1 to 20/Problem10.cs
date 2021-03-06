using System;
using System.Linq;

namespace Euler
{
    public class Problem10
    {
        /* 
        
        https://projecteuler.net/problem=10
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.
        */
        public static long FindSumOfPrimesUnder(int number) {
            var answer = 2L;
            var prime = Shared.Helper.GetNextPrime(2);
            while(prime < number){
                answer += prime;
                prime = Shared.Helper.GetNextPrime(prime);
            }
            return answer;
        }
    }
}

