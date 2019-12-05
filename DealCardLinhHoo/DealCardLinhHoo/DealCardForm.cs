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
            listCardImages.Insert(0, Properties.Resources._2C);
            listCardImages.Insert(1, Properties.Resources._2D);
            listCardImages.Insert(2, Properties.Resources._2H);
            listCardImages.Insert(3, Properties.Resources._2S);

            listCardImages.Insert(4, Properties.Resources._3C);
            listCardImages.Insert(5, Properties.Resources._3D);
            listCardImages.Insert(6, Properties.Resources._3H);
            listCardImages.Insert(7, Properties.Resources._3S);

            listCardImages.Insert(8, Properties.Resources._4C);
            listCardImages.Insert(9, Properties.Resources._4D);
            listCardImages.Insert(10, Properties.Resources._4H);
            listCardImages.Insert(11, Properties.Resources._4S);

            listCardImages.Insert(12, Properties.Resources._5C);
            listCardImages.Insert(13, Properties.Resources._5D);
            listCardImages.Insert(14, Properties.Resources._5H);
            listCardImages.Insert(15, Properties.Resources._5S);

            listCardImages.Insert(16, Properties.Resources._6C);
            listCardImages.Insert(17, Properties.Resources._6D);
            listCardImages.Insert(18, Properties.Resources._6H);
            listCardImages.Insert(19, Properties.Resources._6S);

            listCardImages.Insert(20, Properties.Resources._7C);
            listCardImages.Insert(21, Properties.Resources._7D);
            listCardImages.Insert(22, Properties.Resources._7H);
            listCardImages.Insert(23, Properties.Resources._7S);

            listCardImages.Insert(24, Properties.Resources._8C);
            listCardImages.Insert(25, Properties.Resources._8D);
            listCardImages.Insert(26, Properties.Resources._8H);
            listCardImages.Insert(27, Properties.Resources._8S);

            listCardImages.Insert(28, Properties.Resources._9C);
            listCardImages.Insert(29, Properties.Resources._9D);
            listCardImages.Insert(30, Properties.Resources._9H);
            listCardImages.Insert(31, Properties.Resources._9S);

            listCardImages.Insert(32, Properties.Resources._10C);
            listCardImages.Insert(33, Properties.Resources._10D);
            listCardImages.Insert(34, Properties.Resources._10H);
            listCardImages.Insert(35, Properties.Resources._10S);

            listCardImages.Insert(36, Properties.Resources.JC);
            listCardImages.Insert(37, Properties.Resources.JD);
            listCardImages.Insert(38, Properties.Resources.JH);
            listCardImages.Insert(39, Properties.Resources.JS);

            listCardImages.Insert(40, Properties.Resources.KC);
            listCardImages.Insert(41, Properties.Resources.KD);
            listCardImages.Insert(42, Properties.Resources.KH);
            listCardImages.Insert(43, Properties.Resources.KS);

            listCardImages.Insert(44, Properties.Resources.QC);
            listCardImages.Insert(45, Properties.Resources.QD);
            listCardImages.Insert(46, Properties.Resources.QH);
            listCardImages.Insert(47, Properties.Resources.QS);

            listCardImages.Insert(48, Properties.Resources.AC);
            listCardImages.Insert(49, Properties.Resources.AD);
            listCardImages.Insert(50, Properties.Resources.AH);
            listCardImages.Insert(51, Properties.Resources.AS);

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

                // clear images
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
