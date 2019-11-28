/*
 * Created by: Linh Ho
 * Created on: November 27th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Min Value
 * This program...shows a list box of numbers between 1 and 500, and displays the lowest number in a label.
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

namespace MinValueLinhHo
{
    public partial class frmMinValue : Form
    {
        public frmMinValue()
        {
            InitializeComponent();
            // hide label
            lblAnswer.Hide();
        }

        private int GetMinValue(int[] tmpArrayOfNum)
        {
            // this function calculates the sum of the values in an array
            int tmpMinValue = 501;
            
            // look through every object in the array
            foreach (int arrayNum in tmpArrayOfNum)
            {
                if (tmpMinValue > arrayNum)
                {
                    // set min value to the array num
                    tmpMinValue = arrayNum;
                }
                
            }

            return tmpMinValue;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables and constants
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayNum = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, minValue;
            Random randomNumberGenerator = new Random();

            // Clear list box
            this.lstNumbers.Items.Clear();

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // generate a new random number between 1 and 500
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER + 1);

                // assign the random number to the cell at position counter in the array
                arrayNum[counter] = randomNumber;

                // Display list
                this.lstNumbers.Items.Add(randomNumber);

                // refresh the form to display the new item in the list box
                this.Refresh();
            }

            // get the min value in the array
            minValue = GetMinValue(arrayNum);

            // show label
            lblAnswer.Show();

            // display the min value in the label 
            this.lblAnswer.Text = "The minimum value is: " + minValue;
        }
    }
}
