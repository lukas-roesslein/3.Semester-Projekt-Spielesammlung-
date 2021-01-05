using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Gewinnt_Campus_Projekt
{
    /// <summary>
    /// Auswertung des Spielfeldes
    /// </summary>
    class Spiellogik
    {
        // ---------- Eigenschaften ----------
        private int[,] Arry;
        private int Spielzugcounter = 0;      // Anzahl gespielte Runden, für Unentschieden beim letzten Move nötig
        private int _Spielzug;          // Welcher Spieler dran ist (1 = Spieler 1, 2 = Spieler 2)
        public int Spielzug
        {
            get { return _Spielzug; }
        }
        private bool _Finish;
        public bool Finish
        {
            get { return _Finish; }
        }
        private int _Winner = 0;
        public int Winner          //  Spielervariable isgt 1 und 2
        {
            get { return _Winner; }
        }
        // Konstruktor
        public Spiellogik(int aFieldCountX, int aFieldCountY)
        {
            Arry = new int[aFieldCountX, aFieldCountY];
            _Spielzug = 1;
            _Finish = false;
        }

        // Methoden
        /// <summary>
        /// Gibt den Gewinner an.
        /// </summary>
        /// <param name="aFieldX">Gibt an wer den letzten Stein gesetzt hat</param>
        /// <returns></returns>
        public int Move(int aFieldX)
        {
            int FieldY = -1;
            if (!Finish)
            {
                for (int i = Arry.GetLength(1) - 1; i >= 0; i--)
                {
                    if (Arry[aFieldX - 1, i] == 0)
                    {
                        Arry[aFieldX - 1, i] = _Spielzug;
                        Spielzugcounter++;
                        FieldY = i + 1;
                        CheckWin(aFieldX, FieldY);
                        if (_Spielzug == 1)
                            _Spielzug = 2;
                        else
                            _Spielzug = 1;
                        return FieldY;
                    }
                }
            }
            return FieldY;
        }

        // Gewinn Methode
        /// <summary>
        /// Überprüfung der Steinanordnung
        /// </summary>
        /// <param name="aFieldX">Koordinate in X</param>
        /// <param name="aFieldY">Koordinate in Y</param>
        /// <returns></returns>
        public bool CheckWin(int aFieldX, int aFieldY)
        {
            int Spielfigurenzaehler = 0;
            // vom Spieler gesetzte Stein
            int LastMoveFieldX = aFieldX - 1;
            int LastMoveFieldY = aFieldY - 1;
            // Rand der Spielfeld
            int SpielfeldLastRowX = (Arry.GetLength(0) - 1);
            int SpielfeldLastRowY = (Arry.GetLength(1) - 1);

            // Überprüfung Horizontale
            Spielfigurenzaehler = 0;
            for (int i = 1; i <= 3; i++)
            {
                if ((LastMoveFieldX + i) <= SpielfeldLastRowX)
                {
                    if (Arry[LastMoveFieldX + i, LastMoveFieldY] == Spielzug)
                    {
                        Spielfigurenzaehler++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (Spielfigurenzaehler >= 3)
            {
                _Finish = true;
                _Winner = Spielzug;
                return true;
            }
            for (int i = 1; i <= 3; i++)
            {
                if ((LastMoveFieldX - i) >= 0)
                {
                    if (Arry[LastMoveFieldX - i, LastMoveFieldY] == Spielzug)
                    {
                        Spielfigurenzaehler++;
                        if (Spielfigurenzaehler >= 3)
                        {
                            _Finish = true;
                            _Winner = Spielzug;
                            return true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }


            // Überprüfung Vertikal
            Spielfigurenzaehler = 0;
            for (int i = 1; i <= 3; i++)
            {
                if (((LastMoveFieldX + i) <= SpielfeldLastRowX) && ((LastMoveFieldY + i) <= SpielfeldLastRowY))
                {
                    if (Arry[LastMoveFieldX + i, LastMoveFieldY + i] == Spielzug)
                    {
                        Spielfigurenzaehler++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (Spielfigurenzaehler >= 3)
            {
                _Finish = true;
                _Winner = Spielzug;
                return true;
            }
            for (int i = 1; i <= 3; i++)
            {
                if (((LastMoveFieldX - i) >= 0) && ((LastMoveFieldY - i) >= 0))
                {
                    if (Arry[LastMoveFieldX - i, LastMoveFieldY - i] == Spielzug)
                    {
                        Spielfigurenzaehler++;
                        if (Spielfigurenzaehler >= 3)
                        {
                            _Finish = true;
                            _Winner = Spielzug;
                            return true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Spielfigurenzaehler = 0;
            for (int i = 1; i <= 3; i++)
            {
                if ((LastMoveFieldY + i) <= SpielfeldLastRowY)
                {
                    if (Arry[LastMoveFieldX, LastMoveFieldY + i] == Spielzug)
                    {
                        Spielfigurenzaehler++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (Spielfigurenzaehler >= 3)
            {
                _Finish = true;
                _Winner = Spielzug;
                return true;
            }


            // Überprüfung Diagonalen
            for (int i = 1; i <= 3; i++)
            {
                if (((LastMoveFieldX + i) <= SpielfeldLastRowX) && ((LastMoveFieldY - i) >= 0))
                {
                    if (Arry[LastMoveFieldX + i, LastMoveFieldY - i] == Spielzug)
                    {
                        Spielfigurenzaehler++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (Spielfigurenzaehler >= 3)
            {
                _Finish = true;
                _Winner = Spielzug;
                return true;
            }
            for (int i = 1; i <= 3; i++)
            {
                if (((LastMoveFieldX - i) >= 0) && ((LastMoveFieldY + i) <= SpielfeldLastRowY))
                {
                    if (Arry[LastMoveFieldX - i, LastMoveFieldY + i] == Spielzug)
                    {
                        Spielfigurenzaehler++;
                        if (Spielfigurenzaehler >= 3)
                        {
                            _Finish = true;
                            _Winner = Spielzug;
                            return true;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }


            // Check Unentschieden
            if (Spielzugcounter >= (Arry.GetLength(0) * Arry.GetLength(1)))
            {
                _Finish = true;
                _Winner = 0;
            }
            return false;
        }
    }
}

