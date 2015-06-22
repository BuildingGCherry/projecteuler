using System.Linq;

namespace Euler
{
    public class EulerHelper
    {
        #region Methods

        public long GetLargestPrimeNumber(long number)
        {
            var newNum = number;
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

        public bool IsPalindrome(long number)
        {
            var s = number.ToString();

            ///this can be done very easy with the use of linq
            return s.Reverse().SequenceEqual(s);

        }

        public bool IsPrimeNumber(long number)
        {
            for (var i = 2; i <= (number/2); i++)
            {
                if (number%i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        #endregion
    }
}