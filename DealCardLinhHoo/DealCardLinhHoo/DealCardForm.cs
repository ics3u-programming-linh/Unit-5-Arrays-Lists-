/*
 * Created by: Linh Ho
 * Created on: December 8th, 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Deal Card
 * This program...generates 52 cards without repeating...
 * when it runs out of cards, it will display a message box
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

namespace DealCardLinhHoo
{
    public partial class frmDealCard : Form
    {
        
        public frmDealCard()
        {
            InitializeComponent();
            NewDeck();
        }

        // create a list for the deck of Cards
        List<Image> listCardImages = new List<Image>();

        // declare variables
        int randomNumber;
        Random randomNumberGenerator = new Random();

        private void NewDeck()
        {
            // Make cards face down
            CardsDown();

            // Populate list with 52 cards
            listCardImages.Add(Properties.Resources._2C);
            listCardImages.Add(Properties.Resources._2D);
            listCardImages.Add(Properties.Resources._2H);
            listCardImages.Add(Properties.Resources._2S);

            listCardImages.Add(Properties.Resources._3C);
            listCardImages.Add(Properties.Resources._3D);
            listCardImages.Add(Properties.Resources._3H);
            listCardImages.Add(Properties.Resources._3S);

            listCardImages.Add(Properties.Resources._4C);
            listCardImages.Add(Properties.Resources._4D);
            listCardImages.Add(Properties.Resources._4H);
            listCardImages.Add(Properties.Resources._4S);

            listCardImages.Add(Properties.Resources._5C);
            listCardImages.Add(Properties.Resources._5D);
            listCardImages.Add(Properties.Resources._5H);
            listCardImages.Add(Properties.Resources._5S);

            listCardImages.Add(Properties.Resources._6C);
            listCardImages.Add(Properties.Resources._6D);
            listCardImages.Add(Properties.Resources._6H);
            listCardImages.Add(Properties.Resources._6S);

            listCardImages.Add(Properties.Resources._7C);
            listCardImages.Add(Properties.Resources._7D);
            listCardImages.Add(Properties.Resources._7H);
            listCardImages.Add(Properties.Resources._7S);

            listCardImages.Add(Properties.Resources._8C);
            listCardImages.Add(Properties.Resources._8D);
            listCardImages.Add(Properties.Resources._8H);
            listCardImages.Add(Properties.Resources._8S);

            listCardImages.Add(Properties.Resources._9C);
            listCardImages.Add(Properties.Resources._9D);
            listCardImages.Add(Properties.Resources._9H);
            listCardImages.Add(Properties.Resources._9S);

            listCardImages.Add(Properties.Resources._10C);
            listCardImages.Add(Properties.Resources._10D);
            listCardImages.Add(Properties.Resources._10H);
            listCardImages.Add(Properties.Resources._10S);

            listCardImages.Add(Properties.Resources.JC);
            listCardImages.Add(Properties.Resources.JD);
            listCardImages.Add(Properties.Resources.JH);
            listCardImages.Add(Properties.Resources.JS);

            listCardImages.Add(Properties.Resources.KC);
            listCardImages.Add(Properties.Resources.KD);
            listCardImages.Add(Properties.Resources.KH);
            listCardImages.Add(Properties.Resources.KS);

            listCardImages.Add(Properties.Resources.QC);
            listCardImages.Add(Properties.Resources.QD);
            listCardImages.Add(Properties.Resources.QH);
            listCardImages.Add(Properties.Resources.QS);

            listCardImages.Add(Properties.Resources.AC);
            listCardImages.Add(Properties.Resources.AD);
            listCardImages.Add(Properties.Resources.AH);
            listCardImages.Add(Properties.Resources.AS);

        }

        private void CardsDown()
        {
            // Set the 6 images to face down
            picCard1.Image = Properties.Resources.Back;
            picCard2.Image = Properties.Resources.Back;
            picCard3.Image = Properties.Resources.Back;
            picCard4.Image = Properties.Resources.Back;
            picCard5.Image = Properties.Resources.Back;
            picCard6.Image = Properties.Resources.Back;

        }

        private void DealCard(ref PictureBox aPictureBox, int randomIndex)
        {
            // displays a picture from the reference, and removes the card out of the list
            Image card = listCardImages[randomIndex];
            aPictureBox.Image = card;
            listCardImages.RemoveAt(randomIndex);
        }

        private void GenerateRandomNumber()
        {
            // generate a random number
            randomNumber = randomNumberGenerator.Next(0, listCardImages.Count() - 1);
        }

        private void Reshuffle()
        {
            if (listCardImages.Count() <= 0)
            {
                // show message box if cards run out
                MessageBox.Show("Ran out of cards. Deck is reshuffling.");

                // clear image
                this.listCardImages.Clear();

                // Call New Deck and Cards Down
                CardsDown();
                NewDeck();
                
            }
            else
            {
               // call generate random number function
               GenerateRandomNumber();
            }
        }
        private void PicCard1_Click(object sender, EventArgs e)
        {
            // Call reshuffle to check for cards left
            Reshuffle();

            // get the card reference to this card
            DealCard(ref this.picCard1, randomNumber);
        }

        private void PicCard2_Click(object sender, EventArgs e)
        {
            // Call reshuffle to check for cards left
            Reshuffle();

            // get the card reference to this card
            DealCard(ref this.picCard2, randomNumber);
        }

        private void PicCard3_Click(object sender, EventArgs e)
        {
            // Call reshuffle to check for cards left
            Reshuffle();

            // get the card reference to this card
            DealCard(ref this.picCard3, randomNumber);
        }

        private void PicCard4_Click(object sender, EventArgs e)
        {
            // Call reshuffle to check for cards left
            Reshuffle();

            // get the card reference to this card
            DealCard(ref this.picCard4, randomNumber);
        }

        private void PicCard5_Click(object sender, EventArgs e)
        {
            // Call reshuffle to check for cards left
            Reshuffle();

            // get the card reference to this card
            DealCard(ref this.picCard5, randomNumber);
        }

        private void PicCard6_Click(object sender, EventArgs e)
        {
            // Call reshuffle to check for cards left
            Reshuffle();

            // get the card reference to this card
            DealCard(ref this.picCard6, randomNumber);
        }
    }
}
