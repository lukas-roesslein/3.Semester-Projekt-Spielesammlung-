using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;



namespace Spielesammlung
{
    /// <summary>
    /// Wertet das Spielgeschehen aus
    /// </summary>
    class Spielauswertung
    {
        Spiellogik Spiel;
        Spielfeld Spielfeld;

        ~Spielauswertung()
        {
            Spielfeld = null;
            Spiel = null;
        }
        /// <summary>
        /// Klickevent für die X Spalte
        /// </summary>
       
        public void PlayerClick(MouseEventArgs e)
        {
            if (Spielfeld.ValidSpielfeldCoordinate(e.X, e.Y))
            {
                int FieldX = Spielfeld.GetFieldX(e.X);
                int FieldY = Spiel.Move(FieldX);
                if (!(FieldY == -1))
                {
                    Color Color;
                    if (Spiel.Spielzug == 2)
                        Color = System.Drawing.Color.Red;
                    else
                        Color = System.Drawing.Color.Yellow;
                    Spielfeld.PrintCircle(Color, FieldX, FieldY);
                }
            }
        }

        /// <summary>
        /// Erstellt eine neue Spielrunde
        /// </summary>
        /// <param name="Form">Erstellt neue Form</param>
        /// <param name="aFieldCountX">Anzahl der Spalten</param>
        /// <param name="aFieldCountY">Anzahl der Reihen</param>
        /// <param name="aFieldSize">Größe in Pixel</param>
        /// <param name="aLocationX">Platzierung im Fenster X Koordinate</param>
        /// <param name="aLocationY">Platzierung im Fenster Y Koordinate</param>
        public void NewSpiel(System.Windows.Forms.Form Form, int aFieldCountX, int aFieldCountY, int aFieldSize, int aLocationX, int aLocationY)
        {
            Spielfeld = new Spielfeld(Form, aFieldCountX, aFieldCountY, aFieldSize, aLocationX, aLocationY);
            Spiel = new Spiellogik(aFieldCountX, aFieldCountY);
        }

        /// <summary>
        /// Beendet das Spiel
        /// </summary>
        /// <returns>true wenn Spiel beendet durch Sieg oder unentschieden.</returns>
        public bool Finish()
        {
            return Spiel.Finish;
        }

        /// <summary>
        /// Gibt den Gewinner an
        /// </summary>
        /// <returns>0 bei unentschieden, 1 Spieler 1 gewonnen, 2 Spieler 2 gewonnen</returns>
        public int GetWinner()
        {
            return Spiel.Winner;
        }

        /// <summary>
        /// Gibt zurück wer am Zug ist
        /// </summary>
        /// <returns>1 wenn Spieler 1 am Zug ist, ansonsten Spieler 2</returns>
        public int GetTurn()
        {
            Thread.Sleep(500); //Mir ist leider erst kurz vor Abgabe aufgefallen, das bei schneller eingabe mein Array Probleme kriegen kann:/
            return Spiel.Spielzug;
        }
    }
}

