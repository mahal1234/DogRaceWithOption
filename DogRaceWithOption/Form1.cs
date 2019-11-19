using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRaceWithOption
{
    public partial class Form1 : Form
    {
        int player = 0;
        RaceCoat obj = new RaceCoat();

        public Form1()
        {
            InitializeComponent();
        }

        // this is for selection of player that which player is selected and this work with variables seeing that player should be once added
        public void passValue(int player){

            MessageBox.Show("" + player);
            // if the player 1 is selected it wil display message and text written about balance of the player
            if (player == 1)
            {
                MessageBox.Show("Sandy is selected for the race ");
                
                obj.Player1.Text = "Sandy has 100 dollar ";
            }
            // if the player 2 is selected it wil display message and text written about balance of the player
            else if (player == 2) {
                MessageBox.Show("Anny is selected for the race ");

                
                obj.Player2.Text = "Anny has 100 dollar ";
            }
            // if the player 3 is selected it wil display message and text written about balance of the player
            else if (player == 3)
            {
                MessageBox.Show("Mandy is selected for the race ");
                
                
                obj.Player3.Text = "Mandy has 100 dollar ";
            } 

        }
        private void Player1_Click(object sender, EventArgs e)
        {

            if (player <3)
            {
                player++;
                passValue(player);
                Player1.Enabled = false;

            }
            else {
                MessageBox.Show("three player is already selected ");
            }
        }

        private void Player2_Click(object sender, EventArgs e)
        {
            //this is for player selection 
            if (player < 3)
            {
                player++;
                passValue(player);
                Player2.Enabled = false;
            }
            else
            {
                MessageBox.Show("three player is already selected ");
            }
        }

        private void Player3_Click(object sender, EventArgs e)
        {
            //this is for player selection 
            if (player < 3)
            {
                player++;
                passValue(player);
                Player3.Enabled = false;
            }
            else
            {
                MessageBox.Show("three player is already selected ");
            }
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            //this is for player selection 
            if (player > 0 && player <= 3)
            {
               
                obj.Visible = true;
            }
            else {
                MessageBox.Show("you have to select minimum  2 player ");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
