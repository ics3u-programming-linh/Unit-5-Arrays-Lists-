/*
 * Created by: Linh Ho
 * Created on: Novemeber 27th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Lists
 * This program...calculates the average of marks.
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

namespace ListsLinhHo
{
    public partial class frmLists : Form
    {

        // Create a list
        List<int> myListsOfMarks = new List <int>();
        public frmLists()
        {
            InitializeComponent();
            // Hide the label
            lblAverage.Hide();
        }

        private int CalculateMarks(ref List<int> myListsOfMarks)
        {
            // declare local variables 
            int counter, currentMark;
            int totalMark = 0;
            int tmpAverage = 0;

            // Set counter to 0, increase the counter if it is less than NumberMarks
            for (counter = 0; counter < myListsOfMarks.Count(); counter++)
            {
                // set the current mark to my list of marks
                currentMark = myListsOfMarks[counter];

                // add up the total
                totalMark = totalMark + currentMark;

                // calculate the mark average
                tmpAverage = totalMark / myListsOfMarks.Count();
            }

            return tmpAverage;
                
            
        }
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            // declare local variables
            int userMark = -1;

            // convert the value in the textbox to an integer
            try
            {
                userMark = int.Parse(txtMark.Text);
            }
            // if the user did not enter a valid number, write the error to the command line 
            catch (Exception parseError)
            {
                Console.WriteLine("An error occurred '{O}'", parseError);
            }

            // check if the user entered a number between 0 and 100
            if ( (userMark >= 0) && (userMark <=100) )
            {
                // add the mark to the listbox
                this.lstNumbers.Items.Add(userMark);

                // add the mark to the list
                myListsOfMarks.Add(userMark);

            }
            // otherwise, display an error
            else
            {
                MessageBox.Show("Please enter a number between 0 and 100.", "Invalid Number");
            }

        }

        private void BtnAverage_Click(object sender, EventArgs e)
        {
            // declare local variables
            int average;

            // Show the label
            lblAverage.Show();

            // Call CalculateAverageFunction 
            average = CalculateMarks(ref myListsOfMarks);

            // display user the average
            lblAverage.Text = "The average is " + average;
        }
    }
}
