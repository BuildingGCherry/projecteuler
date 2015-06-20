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
    }
}