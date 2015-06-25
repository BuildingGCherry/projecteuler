#region References

using System;
using System.Windows.Forms;
using Euler.Logic.Problems;

#endregion

namespace Euler
{
    public partial class Form1 : Form
    {
        #region Fields

        private readonly EulerAnswers _eulerAnswers = new EulerAnswers();
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
        ///     Project euler problem 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQ1_Click(object sender, EventArgs e)
        {
            int maxNumber = 1000;
            lblQuestions.Text = "Find the sum of all the multiples of 3 or 5 below " + maxNumber;
            lblAnswers.Text = _eulerAnswers.EulerQuestion1(maxNumber).ToString();
        }

        /// <summary>
        ///     Project euler problem 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQ2_Click(object sender, EventArgs e)
        {
            int maxFibNumber = 4000000;

            lblQuestions.Text =
                "By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.";
            lblAnswers.Text = _eulerAnswers.EulerQuestion2(maxFibNumber).ToString();
        }

        /// <summary>
        ///     Project euler problem 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQ3_Click(object sender, EventArgs e)
        {
            long maxNumber = 600851475143;

            lblQuestions.Text =
                "The prime factors of 13195 are 5, 7, 13 and 29. What is the largest prime factor of the number 600851475143. " +
                "(A Prime Number can be divided evenly only by 1, or itself. And it must be a whole number greater than 1. " +
                "Example: 5 can only be divided evenly by 1 or 5, so it is a prime number. But 6 can be divided evenly by 1, 2, 3 and 6 so it is NOT a prime number " +
                "(it is a composite number)";

            lblAnswers.Text = _eulerAnswers.EulerQuestion3(maxNumber).ToString();
        }

        /// <summary>
        ///     Project euler problem 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQ4_Click(object sender, EventArgs e)
        {
            lblQuestions.Text =
                "A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is " +
                "9009 = 91 × 99.Find the largest palindrome made from the product of two 3-digit numbers.";

            lblAnswers.Text = _eulerAnswers.EulerQuestion4().ToString();
        }

        /// <summary>
        ///     Project euler problem 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQ5_Click(object sender, EventArgs e)
        {
            int maxNumber = 20;
            lblQuestions.Text =
                "What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?";
            lblAnswers.Text = _eulerAnswers.EulerQuestion5(maxNumber).ToString();
        }

        /// <summary>
        ///     Project euler problem 10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQ10_Click(object sender, EventArgs e)
        {
            long maxNumber = 2000000;


            lblQuestions.Text = "Find the sum of all the primes below " + maxNumber;

            lblAnswers.Text = _eulerAnswers.EulerQuestion10(maxNumber).ToString();
        }



        #endregion
    }
}