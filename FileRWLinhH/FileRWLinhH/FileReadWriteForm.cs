/*
 * Created by: Linh Ho
 * Created on: December 20th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - String Equality
 * This program...goes through a parse of each line of a text file and outputs it into another text file
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

namespace FileRWLinhH
{
    public partial class frmFileReadWrite : Form
    {
        public frmFileReadWrite()
        {
            InitializeComponent();
            // hide output
            lblOutput.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // read each line of the file into a string array. each element of the array is one line of the file
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            // array of characters that I want to take out when I split the line into words (spaces, tabs)
            char[] charSeperators = new char[] { ' ', '\t' };

            // the output string where I will put my results
            string output = "";

            // go through and compare each string on each line of the file
            foreach (string line in lines)
            {
                // split each line into words and put them into an array. I am assuming there are only two words on the line.
                string[] words = line.Split(charSeperators, StringSplitOptions.RemoveEmptyEntries);

                if (StringsAreEqual(words[0], words[1]) == true)
                {
                    // concentrate the output to the string. There must be \r\n\ so that it goes onto a new line in the text file.
                    output = output + "True\r\n";
                }
                else
                {
                    // concentrate the output to the string. There must be \r\n\ so that it goes onto a new line in the text file. 
                    output = output + "False\r\n";

                }

                // WriteAllText creates a file, writes the specified string to the file, 
                // and then closes the file. You do NOT need to call Flush() or Close().
                // If the file already exists, it overwrites the file.
                System.IO.File.WriteAllText(@"output.txt", output);

                // Show the label notifying the user that process is done
                this.lblOutput.Show();
            }


        }

        private bool StringsAreEqual(string stringOne, string stringTwo)
        {
            // Declare local variables
            bool isEqual = false;

            // Make the strings uppercase
            stringOne = stringOne.ToUpper();
            stringTwo = stringTwo.ToUpper();

            // If strings are equal still, set isEqual to true
            if (stringOne == stringTwo)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }

            // return bool
            return isEqual;
        }
    }
}

