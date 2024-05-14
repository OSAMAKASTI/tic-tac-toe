using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bn_Click(object sender, EventArgs e)
        {
            if (text1.Text == "" && text2.Text == "")
            {
                MessageBox.Show("there is no players");
            }
            else if (text1.Text == "")
            {
                MessageBox.Show("there is no player 1");
            }
            else if (text2.Text == "")
            {
                MessageBox.Show("there is no player 2");
            }
            else
            {
                Form1 ahmad = new Form1();
                ahmad.text1 = text1.Text;
                ahmad.text2 = text2.Text;
                ahmad.Show();
                Hide();
            }
        }
    }
}
