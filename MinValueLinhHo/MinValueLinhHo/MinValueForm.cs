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
    public partial class MinValueForm : Form
    {
        public MinValueForm()
        {
            InitializeComponent();
            // hide label
            lblAnswer.Hide();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables and constants
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayOfMin = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, minValue;
            Random randomNumberGenerator = new Random();
            // Clear list box
            this.lstNumbers.Items.Clear();

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // generate a new random number between 1 and 500
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER + 1);

                // assign the random number to the cell at position counter in the array
                arrayOfMin[counter] = randomNumber;

                // Display list
                this.lstNumbers.Items.Add(randomNumber);

                // refresh the form to display the new item in the list box
                this.Refresh();
            }

            // get the min value in the array
            minValue = GetMinValue(arrayOfMin);

            // show label
            lblAnswer.Show();

            // display the min value in the label 
            this.lblAnswer.Text = "The max value is: " + minValue;
        }
    }
}
