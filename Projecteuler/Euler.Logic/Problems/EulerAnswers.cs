using System;
using System.Collections.Generic;
using System.Linq;
using Euler.Logic.Interfaces;

namespace Euler.Logic.Problems
{
    public class EulerAnswers : IEulerProblems
    {
        private readonly EulerHelper _eulerHelper = new EulerHelper();

        /// <summary>
        ///     Find the sum of all the multiples of 3 or 5 below 1000
        /// </summary>
        /// <returns>string</returns>
        public int EulerQuestion1(int maxNumber)
        {
            int sum = 0;

            for (int i = 0; i < maxNumber; i++)
            {
                if (i%3 == 0 && i%5 == 0)
                {
                    sum += i;
                }
                else if (i%3 == 0)
                {
                    sum += i;
                }
                else if (i%5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        /// <summary>
        ///     By considering the terms in the Fibonacci sequence whose values do not exceed four million,
        ///     find the sum of the even-valued terms.
        /// </summary>
        /// <returns></returns>
        public int EulerQuestion2(int maxFibNumber)
        {
            int fibPrevious = 0;
            int fibCurrent = 1;
            int fibNext = 0;
            int totalSum = 0;

            do
            {
                fibNext = fibPrevious + fibCurrent;
                fibPrevious = fibCurrent;
                fibCurrent = fibNext;

                if (fibNext%2 == 0)
                {
                    totalSum += fibNext;
                }
            } while (fibNext <= maxFibNumber);

            return totalSum;
        }

        /// <summary>
        ///     The prime factors of 13195 are 5, 7, 13 and 29. What is the largest prime factor of the number 600851475143.
        ///     (A Prime Number can be divided evenly only by 1, or itself. And it must be a whole number greater than 1.
        ///     Example: 5 can only be divided evenly by 1 or 5, so it is a prime number. But 6 can be divided evenly by 1, 2, 3
        ///     and 6 so it is NOT a prime number
        ///     (it is a composite number)
        /// </summary>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        public long EulerQuestion3(long maxNumber)
        {
            return _eulerHelper.GetLargestPrimeNumber(maxNumber);
        }

        /// <summary>
        ///     A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers
        ///     is
        ///     9009 = 91 × 99.Find the largest palindrome made from the product of two 3-digit numbers
        /// </summary>
        /// <returns></returns>
        public int EulerQuestion4()
        {
            //Alternate solution using for loops

            //var results = new List<int>();
            //for (var x = 100; x < 1000; ++x)
            //{
            //    for (var y = x; y < 1000; ++y)
            //    {
            //        if (_eulerHelper.IsPalindrome(x * y))
            //        {
            //            results.Add(x * y);
            //        }
            //    }
            //}

            //Found that using linq makes this a bit easier
            int results = Enumerable.Range(100, 900).
                SelectMany(x => Enumerable.Range(x, 1000 - x).Select(y => x*y)).
                Where(z => _eulerHelper.IsPalindrome(z)).Max();

            return results;
        }

        /// <summary>
        ///     Find the sum of all the primes below max number
        /// </summary>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        public Int64 EulerQuestion10(long maxNumber)
        {
            IEnumerable<Int64> primeNumbers = _eulerHelper.ESievePrimeNumbers(maxNumber);
            return primeNumbers.Select(x => x).Sum();
        }

        /// <summary>
        ///     What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        /// </summary>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        public int EulerQuestion5(int maxNumber)
        {
            //Slower and more complicated way
            //IEnumerable<int> primes = _eulerHelper.GetPrimeNumbers(maxNumber);
            //int result = 1;

            //foreach (int num in primes)
            //{
            //    var a = (int) Math.Floor(Math.Log(maxNumber)/Math.Log(num));
            //    result = result*((int) Math.Pow(num, a));
            //}

            //Faster and less complicated way
            int res = 1;

            for (int i = 2; i <= maxNumber; i++)
            {
                res = _eulerHelper.LowestCommonMultiple(res, i);
            }

            return res;
        }
    }
}