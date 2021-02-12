using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace War
{
    public partial class Form1 : Form
    {
        //random generator for picking new cards   
        Random randGen = new Random();

        //variables to hold card values 
        int playerCard;
            int cpuCard;

        //variables to hold scores, initialized to 0
        int playerScore = 0;
        int cpuScore = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void warButton_Click(object sender, EventArgs e)
        {
            //clear card back images
            playerCardLabel.Image = null;
            cpuCardLabel.Image = null;

            //get random value between 1 and 10 for both player and cpu
            playerCard = randGen.Next(1,11);
            cpuCard = randGen.Next(1, 11);
            //display card values to the labels
            playerCardLabel.Text = $"{playerCard}";
            cpuCardLabel.Text = $"{cpuCard}";
            // if player value is greater then cpu card
            //    add to player score 
            //    show new player score 
            //    show message saying player won
            if(playerCard > cpuCard)
            {
                playerScore = playerScore + 1;
                playerScoreLabel.Text = $"{playerScore}";
                outputLabel.Text = "player wins";
            }
           

            // if player value is less then cpu card
            //    add to cpu score
            //    show new cpu score
            //    show message saying cpu won
            if(cpuCard > playerCard)
            {
                cpuScore = cpuScore + 1;
                cpuScoreLabel.Text = $"{cpuScore}";
                outputLabel.Text = "cpu wins";
            }

            // if player value is equal to cpu value 
            //    show message that this round is a tie.                  
            if(playerCard == cpuCard)
            {
                outputLabel.Text = "it's a tie";
            }
        }
    }
}
