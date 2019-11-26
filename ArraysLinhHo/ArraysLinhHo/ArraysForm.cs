/*
 * Created by: Linh Ho
 * Created on: November 22, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Introduction to Arrays
 * This program...calculates the average in the array
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

namespace ArraysLinhHo
{
    public partial class frmArrays : Form
    {
        public frmArrays()
        {
            // declare global variables and constants 
            const int MAX_ARRAY_SIZE = 10;
            int[] arrayOfNumbers = new int [MAX_ARRAY_SIZE];

            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables 
            int randomNumber;
            int counter;
            Random randomNumberGenerator = new Random();

            // clear list box 
            this.lstNumber.Items.Clear();

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // generate a new random number between 1 and the MAX_ARRAY_SIZE
                randomNumber = randomNumberGenerator.Next(1, MAX_ARRAY_SIZE + 1);

                // assign the random number to the cell at position "counter" in the array
                arrayOfNumbers[counter] = (randomNumber);

                // add the random number to the list 
                this.lstNumber.Items.Add(randomNumber);

                // refresh the form to display the new item in the list box
                this.Refresh();
            }
        }

        private void BtnAverage_Click(object sender, EventArgs e)
        {
            // declare local variables 
            double average = 0;
            double sum = 0;
            int counter;

            // calculate the sum of all the values in the array 
            for (counter = 0; counter < arrayOfNumbers.Length; counter++)
            {
                sum = sum + arrayOfNumbers[counter];
            }

            // Calculate the average of the values in the array 
            average = sum / arrayOfNumbers[counter];

            // Display the average in the label
            this.lblAverage.Text = "Average: " + average;
        }
    }
}
