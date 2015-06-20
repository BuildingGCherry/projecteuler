#region References

using System;
using System.Globalization;
using System.Windows.Forms;

#endregion

namespace Euler
{
    public partial class Form1 : Form
    {
        private readonly EulerHelper _eulerHelper = new EulerHelper();

        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void btnQ1_Click(object sender, EventArgs e)
        {
            int result = 0;
            int sum = 0;

            for (int i = 0; i < 1000; i++)
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

        private void btnQ2_Click(object sender, EventArgs e)
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
            } while (fibNext <= 4000000);

            lblQuestions.Text =
                "By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.";
            lblAnswers.Text = totalSum.ToString();
        }

        private void btnQ3_Click(object sender, EventArgs e)
        {
            long maxNumber = 600851475143;

            lblAnswers.Text = _eulerHelper.GetLargestPrimeNumber(maxNumber).ToString();
           
            lblQuestions.Text =
                "The prime factors of 13195 are 5, 7, 13 and 29. What is the largest prime factor of the number 600851475143. " +
                "(A Prime Number can be divided evenly only by 1, or itself. And it must be a whole number greater than 1. " +
                "Example: 5 can only be divided evenly by 1 or 5, so it is a prime number. But 6 can be divided evenly by 1, 2, 3 and 6 so it is NOT a prime number " +
                "(it is a composite number)";
        }

        #endregion
    }
}