using System;
using System.Collections.Generic;

namespace Shared
{
    public class Helper
    {
        public static bool IsPrime(long num)
        {
            if (num < 4) return true;
            
            for (var i = 2; i <= (num / 2); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }


        public static long GetNextPrime(long num) {
            var nextPrime = num;
            var isPrime = false;
            while (!isPrime){
                nextPrime++;
                isPrime = IsPrime(nextPrime);
            }
            return nextPrime;
        }


        public static long[] FindPrimeMultiples(long num) {
            List<long> result = new List<long> ();
            var isPrime = IsPrime(num);
            while(!isPrime){
                for(long prime = 2; prime<=num/2; prime = GetNextPrime(prime)){
                    if (num % prime == 0) {
                        num = num / prime;
                        result.Add(prime);
                        break;
                    }
                }
                isPrime = IsPrime(num);
            }
            result.Add(num);
            return result.ToArray();
        }
    }
}
