/*
 * Created by: Linh Ho
 * Created on: November 24th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Max Value
 * This program...displays the max value in the listbox that is shown.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxValueLinhH
{
    public partial class frmMaxValue : Form
    {
        public frmMaxValue()
        {
            InitializeComponent();
            // hide label
            lblAnswer.Hide();
        }

        // Function: GetMaxValue
        // Input: int[] tmpArrayOfIntegers - assume all values in the array are greater than 0
        // Output: the max value in the array
        // Description: This function accepts an array of integers, scans the array and returns the greatest value in the array
        private int GetMaxValue(int[] tmpArrayOfIntegers)
        {
            // Declare local variables
            int tmpMaxValue = -1;
            int counter;

            // Loop until counter is less than integers length
            for (counter = 0; counter < tmpArrayOfIntegers.Length; counter++)
            {
                // Set the number to max value if it's less than the number in the array
                if (tmpMaxValue < tmpArrayOfIntegers[counter])
                {
                    tmpMaxValue = tmpArrayOfIntegers[counter];
                }
            }

            // return temp max value
            return tmpMaxValue;
        }
        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables and constants
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, maxValue;
            Random randomNumberGenerator = new Random();

            // Clear list box
            this.lstNumbers.Items.Clear();

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // generate a new random number between 1 and 500
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER + 1);

                // assign the random number to the cell at position counter in the array
                arrayOfIntegers[counter] = randomNumber;

                // Display list
                this.lstNumbers.Items.Add(randomNumber);

                // refresh the form to display the new item in the list box
                this.Refresh();
            }

            // get the max value in the array
            maxValue = GetMaxValue(arrayOfIntegers);

            // show label
            lblAnswer.Show();

            // display the max value in the label 
            this.lblAnswer.Text = "The max value is: " + maxValue;
        }

    }
}
