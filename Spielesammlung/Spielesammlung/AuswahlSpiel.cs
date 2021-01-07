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
        //Konstruktor
        /// <summary>
        /// Startet die Form zur Auswahl eines Spieles
        /// </summary>
        public AuswahlSpiel()
        {
            InitializeComponent();
        }

        //Click Event zum Starten eines Spieles
        private void B_Start_Click(object sender, EventArgs e)
        {
            string Spieler1 = TB_Name1.Text;   //Die Spielernamen werden aus der jeweiligen Textbox geholt
            string Spieler2 = TB_Name2.Text;
            if (CheckNamen(Spieler1,Spieler2) == 1)  //Übergabe an eine Methode zur Überprüfung der Namen
            {
                this.Hide();    //Auswahl-Spiel Fenster wird verborgen
                //IF-Abfrage um festzustellen welches Spiel in der Combobox ausgewählt wurde
                if (CB_NameSpiel.Text=="TIC TAC TOE")
                {                  
                    TicTacToe tictactoe = new TicTacToe(Spieler1, Spieler2);  //Objekt wird instanziert
                    tictactoe.ShowDialog();   //Macht die Form sichtbar                    
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
                this.Show();    //Macht das Auswahl-Spiel Fenster wieder sichtbar
            }
            else { }
        }


        /// <summary>
        /// Methode um die Richtigkeit der eingegebenen Spielernamen zu überprüfen
        /// </summary>
        /// <param name="Name1">Name des 1.Spielers</param>
        /// <param name="Name2">Name des 2.Spielers</param>
        /// <returns>Error Code</returns>
        private int CheckNamen(string Name1, string Name2)
        {
            if(Name1=="" && Name2=="")        //Es wurden noch keine Namen eingegeben
            {
                MessageBox.Show("Bitte zuerst Spielernamen eingeben.");
                return -1;
            }
            else if(Name1==Name2)         //Es wurden zwei identische Namen eingegeben
            {
                MessageBox.Show("Die Namen dürfen nicht gleich lauten!");
                return -1;
            }
            else if(Name1==""||Name2=="")     //Es wurde nur ein Name eingegeben
            {
                MessageBox.Show("Es wurde nur ein Name angegeben!");
                return -1;
            }
            else        //Es wurden zwei unterschiedliche Namen eingegeben
            {
                return 1;
            }
        }

     
    }
}
