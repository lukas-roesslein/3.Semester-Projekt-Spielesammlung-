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
        private string symbol = "X";
        private string[,] spieleMatrix = new string[3, 3];


        public TicTacToe(string Name1,string Name2)
        {
            InitializeComponent();

            L_Name1.Text = Name1;
            L_Name2.Text = Name2;
        }

        #region Forms-Methoden
        /// <summary>
        /// Ruft die Methode neuesSpiel() auf, um ein neues Spiel zu starten.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            neuesSpiel();
        }

        /// <summary>
        /// Blendet die Statistik ein.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statistikEinblendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_Statistik.Show();
            L_SiegeX_String.Show();
            L_SiegeX_Int.Show();
            L_SiegeO_String.Show();
            L_SiegeO_Int.Show();
            L_Unentschieden_String.Show();
            L_Unentschieden_Int.Show();
            L_Zuege_String.Show();
            L_Zuege_Int.Show();
        }

        /// <summary>
        /// Blendet die Statistik aus.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statistikAusblendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_Statistik.Hide();
            L_SiegeX_String.Hide();
            L_SiegeX_Int.Hide();
            L_SiegeO_String.Hide();
            L_SiegeO_Int.Hide();
            L_Unentschieden_String.Hide();
            L_Unentschieden_Int.Hide();
            L_Zuege_String.Hide();
            L_Zuege_Int.Hide();
        }

        /// <summary>
        /// Setzt die Statistik zurück.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spielStatistikZurücksetzenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            L_SiegeX_Int.Text = "0";
            L_SiegeO_Int.Text = "0";
            L_Unentschieden_Int.Text = "0";
        }

        /// <summary>
        /// Schließt das Spielefenster und kehrt ins Hauptmenü zurück.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spielVerlassenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        #endregion

        /// <summary>
        /// Wechselt den Spiel und fragt nach Sieg und Unentschieden ab.
        /// Aktualisiert außerdem gleich die Statistik und startet ein neues Spiel bei Sieg oder Unentschieden.
        /// </summary>
        private void Spielerwechsel()
        {
            string siegerString = gewinnCheck();
            int labelCounter;

            if (String.IsNullOrEmpty(siegerString))
            {
                if (String.Equals(symbol, "X"))
                    symbol = "O";
                else
                    symbol = "X";

                //Anzahl Zuege aus Label auslesen, um eins erhöhen und dann wieder einschreiben
                labelCounter = Convert.ToInt32(L_Zuege_Int.Text);
                labelCounter++;
                L_Zuege_Int.Text = labelCounter.ToString();
            }
            else if(String.Equals(siegerString, "X"))
            {
                //Anzahl Siege X aus Label auslesen, um eins erhöhen und dann wieder einschreiben
                labelCounter = Convert.ToInt32(L_SiegeX_Int.Text);
                labelCounter++;
                L_SiegeX_Int.Text = labelCounter.ToString();
            }
            else if (String.Equals(siegerString, "O"))
            {
                //Anzahl Siege O aus Label auslesen, um eins erhöhen und dann wieder einschreiben
                labelCounter = Convert.ToInt32(L_SiegeO_Int.Text);
                labelCounter++;
                L_SiegeO_Int.Text = labelCounter.ToString();
            }
            else if (String.Equals(siegerString, "U"))
            {
                //Anzahl Unentschieden aus Label auslesen, um eins erhöhen und dann wieder einschreiben
                labelCounter = Convert.ToInt32(L_Unentschieden_Int.Text);
                labelCounter++;
                L_Unentschieden_Int.Text = labelCounter.ToString();
            }

            //Neues Spiel bei Sieg oder Unentschieden starten
            if (!String.IsNullOrEmpty(siegerString))
                neuesSpiel();
        }


        #region Klickverarbeitung
        private void B_00_Click(object sender, EventArgs e)
        {
            B_00.Text = symbol;
            spieleMatrix[0, 0] = symbol;
            B_00.Enabled = false;
            Spielerwechsel();
        }

        private void B_01_Click(object sender, EventArgs e)
        {
            B_01.Text = symbol;
            spieleMatrix[0, 1] = symbol;
            B_01.Enabled = false;
            Spielerwechsel();
        }

        private void B_02_Click(object sender, EventArgs e)
        {
            B_02.Text = symbol;
            spieleMatrix[0, 2] = symbol;
            B_02.Enabled = false;
            Spielerwechsel();
        }

        private void B_10_Click(object sender, EventArgs e)
        {
            B_10.Text = symbol;
            spieleMatrix[1, 0] = symbol;
            B_10.Enabled = false;
            Spielerwechsel();
        }

        private void B_11_Click(object sender, EventArgs e)
        {
            B_11.Text = symbol;
            spieleMatrix[1, 1] = symbol;
            B_11.Enabled = false;
            Spielerwechsel();
        }

        private void B_12_Click(object sender, EventArgs e)
        {
            B_12.Text = symbol;
            spieleMatrix[1, 2] = symbol;
            B_12.Enabled = false;
            Spielerwechsel();
        }

        private void B_20_Click(object sender, EventArgs e)
        {
            B_20.Text = symbol;
            spieleMatrix[2, 0] = symbol;
            B_20.Enabled = false;
            Spielerwechsel();
        }

        private void B_21_Click(object sender, EventArgs e)
        {
            B_21.Text = symbol;
            spieleMatrix[2, 1] = symbol;
            B_21.Enabled = false;
            Spielerwechsel();
        }

        private void B_22_Click(object sender, EventArgs e)
        {
            B_22.Text = symbol;
            spieleMatrix[2, 2] = symbol;
            B_22.Enabled = false;
            Spielerwechsel();
        }
        #endregion

        /// <summary>
        /// Überprüft, ob ein Sieg oder Unentschieden vorliegt
        /// </summary>
        /// <returns>"X" oder "O" bei Sieg; "U" bei Unentschieden; null bei Weiterspielbarkeit</returns>
        private string gewinnCheck()
        {
            //Horizontale Abfrage
            for (int i = 0; i < 3; i++)
            {
                if (String.Equals(spieleMatrix[i, 0], spieleMatrix[i, 1]) && String.Equals(spieleMatrix[i, 0], spieleMatrix[i, 2]) && !String.IsNullOrEmpty(spieleMatrix[i, 0]))
                    return spieleMatrix[i, 0];
            }

            //Vertikale Abfrage
            for (int i = 0; i < 3; i++)
            {
                if (String.Equals(spieleMatrix[0, i], spieleMatrix[1, i]) && String.Equals(spieleMatrix[0, i], spieleMatrix[2, i]) && !String.IsNullOrEmpty(spieleMatrix[0, i]))
                    return spieleMatrix[0, i];
            }

            //Diagonale Abfrage
            if (String.Equals(spieleMatrix[0, 0], spieleMatrix[1, 1]) && String.Equals(spieleMatrix[0, 0], spieleMatrix[2, 2]) && !String.IsNullOrEmpty(spieleMatrix[0, 0]))
                return spieleMatrix[0, 0];
            if (String.Equals(spieleMatrix[1, 1], spieleMatrix[0, 2]) && String.Equals(spieleMatrix[1, 1], spieleMatrix[2, 0]) && !String.IsNullOrEmpty(spieleMatrix[1, 1]))
                return spieleMatrix[1, 1];

            //Unentschieden
            int counter = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (String.IsNullOrEmpty(spieleMatrix[i, j]))
                        counter++;
                }
            }
            if (counter == 0)
                return "U";

            //Weiterspielbarkeit
            return null;
        }

        /// <summary>
        /// Startet ein neues Spiel.
        /// </summary>
        private void neuesSpiel()
        {
            //Alle Labels leeren und reaktivieren
            B_00.Text = "";
            B_00.Enabled = true;
            B_01.Text = "";
            B_01.Enabled = true;
            B_02.Text = "";
            B_02.Enabled = true;
            B_10.Text = "";
            B_10.Enabled = true;
            B_11.Text = "";
            B_11.Enabled = true;
            B_12.Text = "";
            B_12.Enabled = true;
            B_20.Text = "";
            B_20.Enabled = true;
            B_21.Text = "";
            B_21.Enabled = true;
            B_22.Text = "";
            B_22.Enabled = true;

            //Spielematrix leeren
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    spieleMatrix[i, j] = null;
                }
            }

            //Anzahl Zuege auf 0 setzen
            L_Zuege_Int.Text = "0";
        }

    }
}
