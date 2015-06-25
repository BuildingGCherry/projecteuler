using System.Collections.Generic;

namespace Euler.Logic.Interfaces
{
    public interface IEulerHelper
    {
        long GetLargestPrimeNumber(long number);
        bool IsPalindrome(long number);
        bool IsPrimeNumber(long number);
        IEnumerable<long> ESievePrimeNumbers(long maxNumber);
    }
}