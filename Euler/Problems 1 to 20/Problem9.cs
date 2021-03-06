using System;
using System.Linq;

namespace Euler
{
    public class Problem9
    {
        /* 
        
        https://projecteuler.net/problem=9
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

a2 + b2 = c2
For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
        */
        public int FindTriplet() {
            //Brute force seems fastest 
            for(int a = 3; a < 334; a++) {
                for(int b = a+1; b < (1000 - a) / 2; b++ ){
                    var c = Shared.Helper.CalculateHypoteneuse(a, b);
                    if (c > 0 && c + b + a == 1000)
                        return a*b*c;
                    if (c > 0 && c + b + a > 1000)
                        break;
                }
            }
            return -1;
        }
    }
}

