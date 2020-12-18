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
    public partial class AuswahlSpiel : Form
    {
        public AuswahlSpiel()
        {
            InitializeComponent();
        }
        

        private void B_TicTacToe_Click(object sender, EventArgs e)
        {
        
            string Spieler1 = TB_Name1.Text;
            string Spieler2 = TB_Name2.Text;
            if(CheckNamen()==1)
            {
                this.Hide();
                TicTacToe TTT = new TicTacToe(Spieler1, Spieler2);
                TTT.ShowDialog();   //Macht die Form sichtbar
                this.Show();
                
                //const string message = "Wollen sie ein neues Spiel starten?";
                //const string caption = "Neues Spiel";
                //var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //if (result == DialogResult.Yes)
                //{
                //    this.Show();
                //}
                //else
                //{
                //    this.Close();
                //}
            }
            else { }
           
        }

        private void B_VierGewinnt_Click(object sender, EventArgs e)
        {

        }

        private void B_Schiffeversenken_Click(object sender, EventArgs e)
        {
            string Spieler1 = TB_Name1.Text;
            string Spieler2 = TB_Name2.Text;
            if (CheckNamen() == 1)
            {

                this.Hide();

                SchiffeVersenken schiffeVersenken = new SchiffeVersenken(Spieler1, Spieler2);
                schiffeVersenken.ShowDialog();   //Macht die Form sichtbar
                this.Show();
            }
            else { }
        }

   
        private void Message_Box()
        {
            //const string message = "Wollen sie ein neues Spiel starten?";
            //const string caption = "Neues Spiel";
            //var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result == DialogResult.Yes)
            //{
            //    TTT.ShowDialog();
            //}
            //else
            //{
            //    this.Close();
            //}
        }
        private int CheckNamen()
        {
            string _Name1 = TB_Name1.Text;
            string _Name2 = TB_Name2.Text;

            if(_Name1==_Name2)
            {
                MessageBox.Show("Die Names dürfen nicht gleich lauten!");
                return -1;
            }
            else if(_Name1==""||_Name2=="")
            {
                MessageBox.Show("Mindestens ein Name wurde nicht angegeben!");
                return -1;
            }
            else 
            {
                return 1;
            }
        }
    }
}
