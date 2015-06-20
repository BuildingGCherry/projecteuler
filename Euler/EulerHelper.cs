namespace Euler
{
    public class EulerHelper
    {
        public bool IsPrimeNumber(long number)
        {
            for (int i = 2; i <= (number/2); i++)
            {
                if (number%i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public long GetLargestPrimeNumber(long number)
        {
            long newNum = number;
            long largestFactor = 0;
            long count = 2;

            while (count * count <= newNum)
            {
                if (newNum % count == 0)
                {
                    newNum = newNum / count;
                    largestFactor = count;
                }
                else
                {
                    count = (count == 2) ? 3 : count + 2;
                }
            }
            if (newNum > largestFactor)
            { // the remainder is a prime number
                largestFactor = newNum;     
            }

            return largestFactor;
        }
    }
}