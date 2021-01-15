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

        
        /// <summary>
        /// Click Event zum Starten des ausgewählten Spieles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void B_Start_Click(object sender, EventArgs e)
        {
            bool Namenscheck = CheckNamen(TB_Name1.Text, TB_Name2.Text);    //Überprüfung der eingegebenen Namen
            string Spieler1 = TB_Name1.Text;   //Die Spielernamen werden aus der jeweiligen Textbox geholt
            string Spieler2 = TB_Name2.Text;
            
            if (Namenscheck)  
            {
                this.Hide();    //Auswahl-Spiel Fenster wird verborgen
                //IF-Abfrage um festzustellen welches Spiel in der Combobox ausgewählt wurde
                if (String.Equals(CB_NameSpiel.Text, "TIC TAC TOE"))
                {                  
                    TicTacToe tictactoe = new TicTacToe(Spieler1, Spieler2);  //Objekt wird instanziert
                    tictactoe.ShowDialog();   //Macht die Form sichtbar                    
                }
                else if (String.Equals(CB_NameSpiel.Text, "Schiffe Versenken"))
                {
                    SchiffeVersenken schiffeVersenken = new SchiffeVersenken(Spieler1, Spieler2);
                    schiffeVersenken.ShowDialog();
                }
                else if (String.Equals(CB_NameSpiel.Text, "Vier Gewinnt"))
                {
                    VierGewinnt viergewinnt = new VierGewinnt(Spieler1, Spieler2);
                    viergewinnt.ShowDialog();
                }
                else if(String.Equals(CB_NameSpiel.Text, "Cross Game") )
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
        private bool CheckNamen(string Name1, string Name2)
        {
            if(String.IsNullOrWhiteSpace(Name1) && String.IsNullOrWhiteSpace(Name2))        //Falls keine Namen eingegeben wurden, werden Standardnamen vergeben
            {
                TB_Name1.Text = "Player 1";
                TB_Name2.Text = "Player 2";
                return true;
            }
            else if(String.Equals(Name1, Name2))         //Es wurden zwei identische Namen eingegeben
            {
                MessageBox.Show("Die Namen dürfen nicht gleich lauten!");
                return false;
            }
            else if(String.IsNullOrWhiteSpace(Name1) || String.IsNullOrWhiteSpace(Name2))     //Es wurde nur ein Name eingegeben
            {
                MessageBox.Show("Es wurde nur ein Name angegeben!");
                return false;
            }
            else if (Name1.Length>15 || Name2.Length>15)    //Einer der Namen war zu lang
            {
                MessageBox.Show("Einer der Namen war zu lang (Max. 15 Zeichen).");
                return false;
            }
            else        //Es wurden zwei unterschiedliche Namen eingegeben
            {
                return true;
            }
        }
     
    }
}
