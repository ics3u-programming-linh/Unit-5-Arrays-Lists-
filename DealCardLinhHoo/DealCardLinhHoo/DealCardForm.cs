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
        }

        // create a list for the deck of Cards
        List<Image> listCardImages = new List<Image>();
        int randomIndex;
        
        private void NewDeck()
        {
            
            listCardImages.Insert(randomIndex, Properties.Resources.QS);
            list

        }

        private void PicCard1_Click(object sender, EventArgs e)
        {

        }
    }
}
