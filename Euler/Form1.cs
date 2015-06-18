#region References

using System;
using System.Globalization;
using System.Windows.Forms;

#endregion

namespace Euler
{
    public partial class Form1 : Form
    {
        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

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

            lblQuestions.Text = "By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.";
            lblAnswers.Text = totalSum.ToString();
        }

        #endregion
    }
}