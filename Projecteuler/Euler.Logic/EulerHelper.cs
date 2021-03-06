﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Euler.Logic.Interfaces;

namespace Euler
{
    public class EulerHelper : IEulerHelper
    {
        #region Methods

        /// <summary>
        ///     Get the largest prime number not exceeding the passed in value
        /// </summary>
        /// <param name="number">Highest number to check</param>
        /// <returns>long</returns>
        public long GetLargestPrimeNumber(long number)
        {
            long newNum = number;
            long largestFactor = 0;
            long count = 2;

            while (count*count <= newNum)
            {
                if (newNum%count == 0)
                {
                    newNum = newNum/count;
                    largestFactor = count;
                }
                else
                {
                    count = (count == 2) ? 3 : count + 2;
                }
            }
            if (newNum > largestFactor)
            {
                // the remainder is a prime number
                largestFactor = newNum;
            }

            return largestFactor;
        }

        /// <summary>
        ///     Returns true if number is a Palindrome and false if it is not
        /// </summary>
        /// <param name="number">Number to check</param>
        /// <returns>bool</returns>
        public bool IsPalindrome(long number)
        {
            string s = number.ToString();

            ///this can be done very easy with the use of linq
            return s.Reverse().SequenceEqual(s);
        }

        /// <summary>
        ///     Returns true if number is a prime number and false if it is not
        /// </summary>
        /// <param name="number">Number to check</param>
        /// <returns>bool</returns>
        public bool IsPrimeNumber(long number)
        {
            bool results = true;

            if (number == 1)
            {
                results = false;
            }

            for (int i = 2; i <= (number/2); i++)
            {
                if (number%i == 0)
                {
                    results = false;
                }
            }

            return results;
        }

        /// <summary>
        ///     Using the algorithm from Sieve of Eratosthenes to get all prime numbers
        ///     below the number passed in
        /// </summary>
        /// <param name="maxNumber">Highest number to check</param>
        /// <returns></returns>
        public IEnumerable<long> ESievePrimeNumbers(long maxNumber)
        {
            int sieveBound = (int) (maxNumber - 1)/2;
            int upperSqrt = ((int) Math.Sqrt(maxNumber) - 1)/2;

            var PrimeBits = new BitArray(sieveBound + 1, true);

            // Implementing Eratosthenes https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes 
            for (int i = 1; i <= upperSqrt; i++)
            {
                if (PrimeBits.Get(i))
                {
                    // Using the Eratosthenes pattern to skip and eliminate numbers as needed.
                    // Also skipping the even numbers since they will generally not be prime
                    // (The j += 2 * i + 1 ensures we are incrementing by an odd number each time)
                    for (int j = i*2*(i + 1); j <= sieveBound; j += 2*i + 1)
                    {
                        PrimeBits.Set(j, false);
                    }
                }
            }

            // Google helped me figure out this part https://en.wikipedia.org/wiki/Logarithm the Math.Log confused me
            // Here we are converting our bitarray into a list of integers that we can actually use
            var numbers = new List<Int64>((int) (maxNumber/(Math.Log(maxNumber) - 1.08366)));

            // Add "2" because we skipped it earlier
            numbers.Add(2);

            // Getting the values from our formula and adding to our list
            for (int i = 1; i <= sieveBound; i++)
            {
                if (PrimeBits.Get(i))
                {
                    numbers.Add(2*i + 1);
                }
            }

            return numbers.ToList();
        }

        /// <summary>
        ///     Get a list of all prime numbers up to the max number
        /// </summary>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        public IEnumerable<int> GetPrimeNumbers(int maxNumber)
        {
            var primes = new List<int>();
            bool isPrime;
            int j;

            primes.Add(2);

            for (int i = 3; i <= maxNumber; i += 2)
            {
                j = 0;
                isPrime = true;
                while (primes[j]*primes[j] <= i)
                {
                    if (i%primes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    j++;
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
            }
            return primes.ToList();
        }

        /// <summary>
        /// Get the greatest common denominator
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int GreatestCommonDenominator(int num1, int num2)
        {
            while (num2 != 0)
            {
                num1 %= num2;
                num1 ^= num2;
                num2 ^= num1;
                num1 ^= num2;
            }

            return num1;
        }

        /// <summary>
        /// Get the lowest common muitiple
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int LowestCommonMultiple(int num1, int num2)
        {
            return num1 / GreatestCommonDenominator(num1, num2) * num2;
        }

        #endregion
    }
}