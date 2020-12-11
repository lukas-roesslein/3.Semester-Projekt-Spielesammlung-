using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung
{
    public partial class TicTacToe : Form
    {
        private bool turn = true; //True = X; Y = O;
        private int turnCount = 0;
        string symbol = "X";
        public TicTacToe(string Name1,string Name2)
        {
            InitializeComponent();
            L_Name1.Text = Name1;
            L_Name2.Text = Name2;
        }

        private void spielVerlassenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void Spielerwechsel()
        {
            if(turn ==true)
            {
                turn = false;
                symbol = "O";
            }
            else
            {
                turn = true;
                symbol = "X";
            }
        }

        private void B_00_Click(object sender, EventArgs e)
        {
            B_00.Text = symbol;
            Spielerwechsel();
            B_00.Enabled = false;
        }

        private void B_01_Click(object sender, EventArgs e)
        {
            B_01.Text = symbol;
            Spielerwechsel();
            B_01.Enabled = false;
        }

        private void B_02_Click(object sender, EventArgs e)
        {
            B_02.Text = symbol;
            Spielerwechsel();
            B_02.Enabled = false;
        }

        private void B_10_Click(object sender, EventArgs e)
        {
            B_10.Text = symbol;
            Spielerwechsel();
            B_10.Enabled = false;
        }

        private void B_11_Click(object sender, EventArgs e)
        {
            B_11.Text = symbol;
            Spielerwechsel();
            B_11.Enabled = false;
        }

        private void B_12_Click(object sender, EventArgs e)
        {
            B_12.Text = symbol;
            Spielerwechsel();
            B_12.Enabled = false;
        }

        private void B_20_Click(object sender, EventArgs e)
        {
            B_20.Text = symbol;
            Spielerwechsel();
            B_20.Enabled = false;
        }

        private void B_21_Click(object sender, EventArgs e)
        {
            B_21.Text = symbol;
            Spielerwechsel();
            B_21.Enabled = false;
        }

        private void B_22_Click(object sender, EventArgs e)
        {
            B_22.Text = symbol;
            Spielerwechsel();
            B_22.Enabled = false;
        }

  
    }
}
