using System;

namespace Shared
{
    public class Helper
    {
        public static bool IsPrime(long num)
        {
            for (var i = 2; i <= (num / 2); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
