using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac
{
    public partial class Form1 : Form
    {
        public string text1;
        public string text2;
        //the variables that i need
        string begin = "p1";//to select beginer
        string round = "p1";//to select player's turn
        int score1 = 0;
        int score2 = 0;
        int win = 0;//to selecter winner
        public Form1()
        {
            InitializeComponent();

        }
        //the Exit button
        private void be_Click(object sender, EventArgs e)
        {
            Close();
        }
        //the Restart button
        private void br_Click(object sender, EventArgs e)
        {
            //swich the Beginer
            if (begin == "p1")
            {
                begin = "p2";
                round = "p2";
            }
            else if (begin == "p2")
            {
                begin = "p1";
                round = "p1";
            }

            //clear the board
            b1.Text = null; b2.Text = null; b3.Text = null;
            b4.Text = null; b5.Text = null; b6.Text = null;
            b7.Text = null; b8.Text = null; b9.Text = null;

            //turn on the buttons
            b1.Enabled = true; b2.Enabled = true; b3.Enabled = true;
            b4.Enabled = true; b5.Enabled = true; b6.Enabled = true;
            b7.Enabled = true; b8.Enabled = true; b9.Enabled = true;

            //give a point to winner
            if (win == 1)
                score1++;
            else if (win == 2)
                score2++;

            //refresh the points of players
            labelA.Text = text1 + "\n" + score1;
            labelB.Text = text2 + "\n" + score2;

            //delete winner's name
            win = 0;
            label1.Text = null;
        }

        private void table_Paint(object sender, PaintEventArgs e)
        {
            //select the player's turn
            if (round == "p1" & label1.Text != "Drew")
                label1.Text = text1 + "\nTurn";
            else if (round == "p2" & label1.Text != "Drew")
                label1.Text = text2 + "\nTurn";

            //cases of win to player 1
            if (b1.Text == "x" & b2.Text == "x" & b3.Text == "x" ||
                b4.Text == "x" & b5.Text == "x" & b6.Text == "x" ||
                b7.Text == "x" & b8.Text == "x" & b9.Text == "x" ||
                b1.Text == "x" & b4.Text == "x" & b7.Text == "x" ||
                b2.Text == "x" & b5.Text == "x" & b8.Text == "x" ||
                b3.Text == "x" & b6.Text == "x" & b9.Text == "x" ||
                b1.Text == "x" & b5.Text == "x" & b9.Text == "x" ||
                b3.Text == "x" & b5.Text == "x" & b7.Text == "x")
            {
                label1.Text = text1 + "\nWin";
                win = 1;
                End();
            }
            //cases of win to player 2
            else if (b1.Text == "o" & b2.Text == "o" & b3.Text == "o" ||
                     b4.Text == "o" & b5.Text == "o" & b6.Text == "o" ||
                     b7.Text == "o" & b8.Text == "o" & b9.Text == "o" ||
                     b1.Text == "o" & b4.Text == "o" & b7.Text == "o" ||
                     b2.Text == "o" & b5.Text == "o" & b8.Text == "o" ||
                     b3.Text == "o" & b6.Text == "o" & b9.Text == "o" ||
                     b1.Text == "o" & b5.Text == "o" & b9.Text == "o" ||
                     b3.Text == "o" & b5.Text == "o" & b7.Text == "o")
            {
                label1.Text = text2 + "\nWin";
                win = 2;
                End();
            }
            //the Drew case
            if (win == 0 &&
                 b1.Enabled == false & b2.Enabled == false & b3.Enabled == false &
                 b4.Enabled == false & b5.Enabled == false & b6.Enabled == false &
                 b7.Enabled == false & b8.Enabled == false & b9.Enabled == false)
            {
                label1.Text = "Drew";
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            if (round == "p1")
            {
                b1.Text = "x";
                round = "p2";
            }
            else
            {
                b1.Text = "o";
                round = "p1";
            }
            b1.Enabled = false;
        }
        
        private void b2_Click(object sender, EventArgs e)
        {
            if (round == "p1")
            {
                b2.Text = "x";
                round = "p2";
            }
            else
            {
                b2.Text = "o";
                round = "p1";
            }
            b2.Enabled = false;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (round == "p1")
            {
                b3.Text = "x";
                round = "p2";
            }
            else
            {
                b3.Text = "o";
                round = "p1";
            }
            b3.Enabled = false;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (round == "p1")
            {
                b4.Text = "x";
                round = "p2";
            }
            else
            {
                b4.Text = "o";
                round = "p1";
            }
            b4.Enabled = false;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (round == "p1")
            {
                b5.Text = "x";
                round = "p2";
            }
            else
            {
                b5.Text = "o";
                round = "p1";
            }
            b5.Enabled = false;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (round == "p1")
            {
                b6.Text = "x";
                round = "p2";
            }
            else
            {
                b6.Text = "o";
                round = "p1";
            }
            b6.Enabled = false;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (round == "p1")
            {
                b7.Text = "x";
                round = "p2";
            }
            else
            {
                b7.Text = "o";
                round = "p1";
            }
            b7.Enabled = false;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (round == "p1")
            {
                b8.Text = "x";
                round = "p2";
            }
            else
            {
                b8.Text = "o";
                round = "p1";
            }
            b8.Enabled = false;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (round == "p1")
            {
                b9.Text = "x";
                round = "p2";
            }
            else
            {
                b9.Text = "o";
                round = "p1";
            }
            b9.Enabled = false;
        }
        //turn off the buttons when win any player
        public void End()
        {
            b1.Enabled = false; b2.Enabled = false; b3.Enabled = false;
            b4.Enabled = false; b5.Enabled = false; b6.Enabled = false;
            b7.Enabled = false; b8.Enabled = false; b9.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelA.Text = text1;
            labelB.Text = text2;
        }
    }
}
