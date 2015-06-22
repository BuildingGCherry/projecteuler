#region References

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

#endregion

namespace Euler
{
    public partial class Form1 : Form
    {
        #region Fields

        private readonly EulerHelper _eulerHelper = new EulerHelper();

        #endregion

        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Project euler problem 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQ1_Click(object sender, EventArgs e)
        {
            var result = 0;
            var sum = 0;

            for (var i = 0; i < 1000; i++)
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

            result = sum;

            lblQuestions.Text = "Find the sum of all the multiples of 3 or 5 below 1000.";
            lblAnswers.Text = result.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Project euler problem 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQ2_Click(object sender, EventArgs e)
        {
            var fibPrevious = 0;
            var fibCurrent = 1;
            var fibNext = 0;
            var totalSum = 0;

            do
            {
                fibNext = fibPrevious + fibCurrent;
                fibPrevious = fibCurrent;
                fibCurrent = fibNext;

                if (fibNext%2 == 0)
                {
                    totalSum += fibNext;
                }
            } while (fibNext <= 4000000);

            lblQuestions.Text =
                "By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.";
            lblAnswers.Text = totalSum.ToString();
        }

        /// <summary>
        /// Project euler problem 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQ3_Click(object sender, EventArgs e)
        {
            var maxNumber = 600851475143;

            lblAnswers.Text = _eulerHelper.GetLargestPrimeNumber(maxNumber).ToString();

            lblQuestions.Text =
                "The prime factors of 13195 are 5, 7, 13 and 29. What is the largest prime factor of the number 600851475143. " +
                "(A Prime Number can be divided evenly only by 1, or itself. And it must be a whole number greater than 1. " +
                "Example: 5 can only be divided evenly by 1 or 5, so it is a prime number. But 6 can be divided evenly by 1, 2, 3 and 6 so it is NOT a prime number " +
                "(it is a composite number)";
        }

        /// <summary>
        /// Project euler problem 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQ4_Click(object sender, EventArgs e)
        {
            lblQuestions.Text =
                "A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is " +
                "9009 = 91 × 99.Find the largest palindrome made from the product of two 3-digit numbers.";

            ///Found that using linq makes this a bit easier
            var results = Enumerable.Range(100, 900).
                SelectMany(x => Enumerable.Range(x, 1000 - x).Select(y => x*y)).
                Where(z => _eulerHelper.IsPalindrome(z)).Max();

            lblAnswers.Text = results.ToString();

            ///Alternate solution using for loops
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

            //lblAnswers.Text = results.Select(x => x).Where(y => _eulerHelper.IsPalindrome(y)).Max().ToString();
        }

        #endregion
        /// <summary>
        /// Project euler problem 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQ10_Click(object sender, EventArgs e)
        {
            var maxNumber = 2000000;
            

            lblQuestions.Text = "Find the sum of all the primes below " + maxNumber;

            //var results = new List<long>();

            //Int64 test = Enumerable.Range(0, maxNumber).Select(x => x).Where(y => _eulerHelper.IsPrimeNumber(y)).Sum();
            //lblAnswers.Text = test.ToString();

            //for (int i = 1; i < maxNumber; i++)
            //{
            //    if (_eulerHelper.IsPrimeNumber(i))
            //    {
            //        results.Add(i);
            //    }
            //}

            //lblAnswers.Text = results.Select(x => x).Sum().ToString();


            IEnumerable<Int64> primeNumbers = _eulerHelper.ESievePrimeNumbers(maxNumber);
            lblAnswers.Text = primeNumbers.Select(x => x).Sum().ToString();

        }
    }
}