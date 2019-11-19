using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DogRaceWithOption.Properties;
namespace DogRaceWithOption
{
    public partial class RaceCoat : Form
    {
       /// <summary>
       /// globa variable that are used to work in the whole process like store the bet amount 
       /// // dog no and other things
       /// </summary>
        int player1 = 100, player2 = 100, player3 = 100;

        int count = 0;

        int plr = 0,winnr=0;
        int plyrcount = 0;

        //object of the ther class 
        running objct = new running();
        result objrslt = new result();

        private void button2_Click(object sender, EventArgs e)
        {
            //when we click on the button 2  then the whole game will be started like running the dog with the help of timer
            if (plr == count)
            {
                timer1.Start();
            }
            else {
                MessageBox.Show("please set the setup before start the race ");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //when the timer moves then the dog will automaticaaly move to the right direction 
            d1.Left = d1.Left + objct.dog1();
            // this code is used to find the winner and display the result for dog 1
            if (objrslt.stop(timer1, d1.Left)==1) {
                timer1.Stop();
                winnr = 1;
                MessageBox.Show("dog 1 won the race ");
                updtAmount();
                button3.Visible = true;
                reset();
            }
            // this code is used to find the winner and display the result for dog 2
            d2.Left = d2.Left + objct.dog2();
            if (objrslt.stop(timer1, d2.Left) == 1)
            {
                timer1.Stop();
                winnr = 2;
                MessageBox.Show("dog 2 won the race ");
                button3.Visible = true;
                updtAmount();
                reset();
            }
            // this code is used to find the winner and display the result for dog 3
            d3.Left = d3.Left + objct.dog3();
            if (objrslt.stop(timer1, d3.Left) == 1)
            {
                timer1.Stop();
                winnr = 3;
                MessageBox.Show("dog 3 won the race ");
                button3.Visible = true;
                updtAmount();
                reset();
            }
            // this code is used to find the winner and display the result  for dog 4
            d4.Left = d4.Left + objct.dog4();
            if (objrslt.stop(timer1, d4.Left) == 1)
            {
                timer1.Stop();
                winnr = 4;
                MessageBox.Show("dog 4 won the race ");
                button3.Visible = true;
                updtAmount();
                reset();
            }

        }

        //reset the game of the whole process
        public void reset() {
            d1.Left = 0;
            d2.Left = 0;
            d3.Left = 0;
            d4.Left = 0;
            winnr = 0;
            plr = 0;
            count = 0;
            nmbet.Value = 1;
            nmdog.Value = 1;
            button2.Enabled = false;
            
        }
        // when the result is shown start button is disabled so that player has to set bet again 
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
        }

        //the prorcess to update the amount or balance of every player 
        public void updtAmount() {
            // the below we have used split function and condional statement to update amount for player1
            if (Player1.Text.ToString().Split(' ').Length > 1 && Player1.Text.ToString().Split(' ').Length ==7) {
                String[] rcrd = Player1.Text.ToString().Split(' ');

                if (rcrd[3].Equals(winnr.ToString())) {
                    player1 = player1 + Convert.ToInt32(rcrd[6]);
                    Player1.Text = rcrd[0] +" has "+player1 +" dollar ";
                }

                if (!rcrd[3].Equals(winnr.ToString()))
                {
                    player1 = player1 - Convert.ToInt32(rcrd[6]);
                    Player1.Text = rcrd[0] + " has " + player1 + " dollar ";
                }



            }
            // the below we have used split function and condional statement to update amount for player 2
            if (Player2.Text.ToString().Split(' ').Length > 1 && Player2.Text.ToString().Split(' ').Length == 7)
            {
                String[] rcrd = Player2.Text.ToString().Split(' ');

                if (rcrd[3].Equals(winnr.ToString()))
                {
                    player2 = player2 + Convert.ToInt32(rcrd[6]);
                    Player2.Text = rcrd[0] + " has " + player2 + " dollar ";
                }

                if (!rcrd[3].Equals(winnr.ToString()))
                {
                    player2 = player2 - Convert.ToInt32(rcrd[6]);
                    Player2.Text = rcrd[0] + " has " + player2 + " dollar ";
                }


            }
            // the below we have used split function and condional statement to update amount for player 3
            if (Player3.Text.ToString().Split(' ').Length > 1 && Player3.Text.ToString().Split(' ').Length == 7)
            {
                String[] rcrd = Player3.Text.ToString().Split(' ');

                if (rcrd[3].Equals(winnr.ToString()))
                {
                    player3 = player3 + Convert.ToInt32(rcrd[6]);
                    Player3.Text = rcrd[0] + " has " + player3 + " dollar ";
                }

                if (!rcrd[3].Equals(winnr.ToString()))
                {
                    player3 = player3 - Convert.ToInt32(rcrd[6]);
                    Player3.Text = rcrd[0] + " has " + player3 + " dollar ";
                }


            }


        }


        public RaceCoat()
        {
            
            InitializeComponent();
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           // with conditional statement and a variable it is shown that this particular player has set bet on that dog and below code is for player 1
            count++;
            if (count == 1) {
                String[] sz = Player1.Text.ToString().Split(' ');
                if (sz.Length > 1 && nmdog.Value < 5 && nmbet.Value <= player1)
                {
                    Player1.Text = "sandy choose dog " + nmdog.Value + " of $ " + nmbet.Value;
                    plr++;
                }
                else if (sz.Length > 1)
                {
                     // message box displaying that to fill correct values
                    MessageBox.Show("choose the correct option ");
                }
                // with conditional statement and a variable it is shown that this particular player has set bet on that dog and below code is for player 2
            }
            else if (count == 2) {
                String[] sz1 = Player2.Text.ToString().Split(' ');
                if (sz1.Length > 1 && nmdog.Value < 5 && nmbet.Value <= player2)
                {
                    plr++;
                    Player2.Text = "Anny choose dog " + nmdog.Value + " of $ " + nmbet.Value;
                }
                else if (sz1.Length > 1)
                {
                    // message box displaying that to fill correct values
                    MessageBox.Show("choose the correct option ");
                }
                // with conditional statement and a variable it is shown that this particular player has set bet on that dog and below code is for player 3
            }
            else if (count==3) {
                String[] sz3 = Player3.Text.ToString().Split(' ');
                if (sz3.Length > 1 && nmdog.Value < 5 && nmbet.Value <= player3)
                {
                    plr++;
                    Player3.Text = "Mandy choose dog " + nmdog.Value + " of $ " + nmbet.Value;
                }
                else if(sz3.Length>1)
                {
                    // message box displaying that to fill correct values
                    MessageBox.Show("choose the correct option ");
                }
            }
            if (Player1.Text.ToString().Split(' ').Length == 7)
            {
                plyrcount++;
            }
            if (Player2.Text.ToString().Split(' ').Length == 7)
            {
                plyrcount++;
            }
            if (Player3.Text.ToString().Split(' ').Length == 7)
            {
                plyrcount++;
            }
            button2.Enabled = true;
          

        }
    }
}
