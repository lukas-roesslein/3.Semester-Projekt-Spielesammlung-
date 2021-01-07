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

        //Click Event zum Starten eines Spieles
        private void B_Start_Click(object sender, EventArgs e)
        {
            string Spieler1 = TB_Name1.Text;   //Die Spielernamen werden aus der jeweiligen Textbox geholt
            string Spieler2 = TB_Name2.Text;
            if (CheckNamen() == 1)  //Übergabe an eine Methode zur Überprüfung der Namen
            {

                this.Hide();    //Auswahl Spiel Fenster wird verborgen
                //IF-Abfrage um festzustellen welches Spiel in der Combobox ausgewählt wurde
                if (CB_NameSpiel.Text=="TIC TAC TOE")
                {                  
                    TicTacToe TTT = new TicTacToe(Spieler1, Spieler2);  //Objekt wird instanziert
                    TTT.ShowDialog();   //Macht die Form sichtbar                    
                }
                else if (CB_NameSpiel.Text == "Schiffe Versenken")
                {      
                    SchiffeVersenken schiffeVersenken = new SchiffeVersenken(Spieler1, Spieler2);
                    schiffeVersenken.ShowDialog();   //Macht die Form sichtbar                 
                }
                else if (CB_NameSpiel.Text == "Vier Gewinnt")
                {
                    TCC viergewinnt = new TCC(Spieler1, Spieler2);
                    viergewinnt.ShowDialog();       //Macht die Form sichtbar                 
                }
                else if(CB_NameSpiel.Text == "Cross Game")
                {
                    CrossGame crossGame = new CrossGame();
                    crossGame.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bitte wählen Sie zunächst ein Spiel aus.");
                }
                this.Show();    //Macht das Auswahl Spiel Fenster wieder sichtbar

            }
            else { }
        }
        //private void B_TicTacToe_Click(object sender, EventArgs e)
        //{
        
        //    string Spieler1 = TB_Name1.Text;
        //    string Spieler2 = TB_Name2.Text;
        //    if(CheckNamen()==1)
        //    {
        //        this.Hide();
        //        TicTacToe TTT = new TicTacToe(Spieler1, Spieler2);
        //        TTT.ShowDialog();   //Macht die Form sichtbar
        //        this.Show();
                
        //        //const string message = "Wollen sie ein neues Spiel starten?";
        //        //const string caption = "Neues Spiel";
        //        //var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //        //if (result == DialogResult.Yes)
        //        //{
        //        //    this.Show();
        //        //}
        //        //else
        //        //{
        //        //    this.Close();
        //        //}
        //    }
        //    else { }
           
        //}

       



   
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

        /// <summary>
        /// Methode um die Richtigkeit der eingegebenen Spielernamen zu überprüfen
        /// </summary>
        /// <returns>Error Code</returns>
        private int CheckNamen()
        {
            string _Name1 = TB_Name1.Text;
            string _Name2 = TB_Name2.Text;
            if(_Name1=="" && _Name2=="")
            {
                MessageBox.Show("Bitte zuerst Spielernamen eingeben.");
                return -1;
            }
            else if(_Name1==_Name2)
            {
                MessageBox.Show("Die Namen dürfen nicht gleich lauten!");
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
