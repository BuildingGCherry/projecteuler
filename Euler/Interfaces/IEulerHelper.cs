using System;
using System.Collections.Generic;

namespace Euler.Interfaces
{
    public interface IEulerHelper
    {
        long GetLargestPrimeNumber(long number);
        bool IsPalindrome(long number);
        bool IsPrimeNumber(long number);
        IEnumerable<Int64> ESievePrimeNumbers(int maxNumber);
    }
}