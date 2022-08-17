using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Author: Katharine Wunderle
//ID: 623748
//Date: 02/10/21
//Goal: To flip a coin randomly heads or tails.

namespace FlipACoin___Katharine_Wunderle
{
    public partial class FlipACoin : Form
    {
        public FlipACoin()
        {
            InitializeComponent();
        }

        private void flipButton_Click(object sender, EventArgs e)
        {
            //Variable to indicate heads
            int sideUP;

            //New random object
            Random rand = new Random();

            //Get a random integer between 0 and 1
            //0 means head 1 means tails
            sideUP = rand.Next(2);

            //Display head side
            if (sideUP == 0)
            { //Display heads up
                headsPicture.Visible = true;
                tailsPicture.Visible = false;
                clearButton.Enabled = true;
                flipButton.Enabled = false;
            }
            else
            { //Display tail side
                tailsPicture.Visible = true;
                headsPicture.Visible = false;
                clearButton.Enabled = true;
                flipButton.Enabled = false;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Hide showing picture
            tailsPicture.Visible = false;
            headsPicture.Visible = false;
            //Enable Flip Button
            flipButton.Enabled = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit the program
            this.Close();
        }
    }
}
