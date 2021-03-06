﻿using System;
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
            if (num == 1) return 2;
            if (num == 2) return 3;            
            var nextPrime = num+2;
            var isPrime = IsPrime(nextPrime);
            while (!isPrime){
                nextPrime+=2;
                isPrime = IsPrime(nextPrime);
            }
            return nextPrime;
        }

        public static int FindFactorsCount(long num) {
            var sqrt = (int)Math.Sqrt(num);            
            var result = 0;
            for (int i = 1; i <= sqrt; i++)
            {
                if (num % i == 0) {
                    result+=2;
                }
            }
            return result;
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

        public static int CalculateHypoteneuse(int a, int b) {
            var answer = Math.Sqrt(a * a + b * b);
            if (Math.Truncate(answer) != answer)
                return -1;
            return (int)answer;
        }
    }
}
