using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spielesammlung
{
    /// <summary>
    /// Fenster des Spiels
    /// </summary>
    public partial class VierGewinnt : Form
    {
        Spielauswertung Spielauswertung;
        public VierGewinnt() : this("Player 1", "Player 2")
        { }
        public VierGewinnt(string Name_Player1, string Name_Player2)
        {
            InitializeComponent();

            Name_Player_1.Text = Name_Player1;
            Name_Player_2.Text = Name_Player2;

        }


        private void btnNewGame_Click(object sender, EventArgs e)
        {


            Spielauswertung = new Spielauswertung();
            Spielauswertung.NewSpiel(this, 7, 6, 70, 50, 100);
            label1.Visible = false;
            label1.Text = "Gewinn Label";
            label3.Text = "Rot";
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Visible = true;
            label2.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Spielauswertung != null)
            {
                Spielauswertung.PlayerClick(e);
                if (Spielauswertung.GetTurn() == 1)
                {
                    label3.Text = "Rot";
                    label3.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    label3.Text = "Gelb";
                    label3.ForeColor = System.Drawing.Color.Yellow;
                }
                if (Spielauswertung.Finish())
                {
                    if (Spielauswertung.GetWinner() == 0)
                        label1.Text = "Unentschieden!";
                    label2.Visible = false;
                    label3.Visible = false;
                    if (Spielauswertung.GetWinner() == 1)
                        label1.Text = Name_Player_1.Text + " hat gewonnen!";
                    label2.Visible = false;
                    label3.Visible = false;
                    if (Spielauswertung.GetWinner() == 2)
                        label1.Text = Name_Player_2.Text + " hat gewonnen!";
                    label2.Visible = false;
                    label3.Visible = false;
                    label1.Visible = true;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Spielauswertung = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label9.Visible == true)
                label9.Visible = false;
            else
                label9.Visible = true;
        }
    }
}

