using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecteuler
{
    public class Problems
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.");
            Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000.");
            Console.WriteLine("Answer:" + Problem1());    
            Console.ReadLine();            
        }

        static public int Problem1()
        {
            var result = 0;
            var sum = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    sum += i;
                }
                else if (i % 3 == 0)
                {
                    sum += i;
                }
                else if (i % 5 == 0)
                {
                    sum += i;
                }
            }

            result = sum;

            return result;
        } 
    }
}
