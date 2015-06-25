using System.Collections.Generic;

namespace Euler.Logic.Interfaces
{
    public interface IEulerHelper
    {
        long GetLargestPrimeNumber(long number);
        bool IsPalindrome(long number);
        bool IsPrimeNumber(long number);
        IEnumerable<long> ESievePrimeNumbers(long maxNumber);
        IEnumerable<int> GetPrimeNumbers(int maxNumber);
        int GreatestCommonDenominator(int num1, int num2);
        int LowestCommonMultiple(int num1, int num2);
    }
}