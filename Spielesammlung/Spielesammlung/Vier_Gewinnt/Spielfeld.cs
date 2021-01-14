using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //Zum Zeichnen eingebunden

namespace _4_Gewinnt_Campus_Projekt
{
    /// <summary>
    /// Zeichnet das Spielfeld und die Token auf
    /// </summary>
    class Spielfeld
    {
        private int LocationX;      // linke obere Ecke
        private int LocationY;      // linke obere Ecke
        private int FieldSize;      // Feldgröße in Pixel
        private int FieldCountX;    // Anzahl Horizontal
        private int FieldCountY;    // Anzahl Vertikal
        private Pen PenPlayground;
        private Graphics formGraphic;


        //Konstruktor
        public Spielfeld(System.Windows.Forms.Form Form, int aFieldCountX, int aFieldCountY, int aFieldSize, int aLocationX, int aLocationY)
        {
            LocationX = aLocationX;
            LocationY = aLocationY;
            FieldSize = aFieldSize;
            FieldCountX = aFieldCountX;
            FieldCountY = aFieldCountY;

            PenPlayground = new System.Drawing.Pen(System.Drawing.Color.White, 2);
            formGraphic = Form.CreateGraphics();
            formGraphic.Clear(System.Drawing.Color.Blue);
            int LocationEndX = LocationX + FieldCountX * FieldSize;
            int LocationEndY = LocationY + FieldCountY * FieldSize;

            // X Reihe  
            for (int i = 0; i < FieldCountY + 1; i++)
            {
                formGraphic.DrawLine(PenPlayground, LocationX, LocationY + i * FieldSize, LocationEndX, LocationY + i * FieldSize);
            }
            // Y Reihe
            for (int i = 0; i < FieldCountX + 1; i++)
            {
                formGraphic.DrawLine(PenPlayground, LocationX + i * FieldSize, LocationY, LocationX + i * FieldSize, LocationEndY);
            }
        }

        //Destruktor
        ~Spielfeld()
        {
            PenPlayground.Dispose();
            formGraphic.Dispose();
        }

        //Methoden
        /// <summary>
        /// Zeichnet die Token
        /// </summary>
        /// <param name="aColor">Gibt die Farbe an</param>
        /// <param name="aFieldCountX">Koordinate in X</param>
        /// <param name="aFieldCountY">Koordinate in Y</param>
        public void PrintCircle(Color aColor, int aFieldCountX, int aFieldCountY) //Kreis/Spieltoken zeichenen 
        {
            int CircleRadius = FieldSize * 80 / 100; // Kreis 80% entspricht der Feldgröße 

            // Mitttige Ausrichtung
            int CircleLocationX = LocationX + (aFieldCountX - 1) * FieldSize + ((FieldSize - CircleRadius) / 2);
            int CircleLocationY = LocationY + (aFieldCountY - 1) * FieldSize + ((FieldSize - CircleRadius) / 2);

            System.Drawing.SolidBrush BrushPlayground = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            formGraphic.FillEllipse(BrushPlayground, CircleLocationX - 2, CircleLocationY - 2, CircleRadius + 4, CircleRadius + 4);
            BrushPlayground.Color = aColor;
            formGraphic.FillEllipse(BrushPlayground, CircleLocationX, CircleLocationY, CircleRadius, CircleRadius);
            BrushPlayground.Dispose();
        }

        /// <summary>
        /// Übergabe der X Koordinate
        /// </summary>
        /// <param name="aX">Gibt die X Spalte an</param>
        /// <returns>Gibt X Koordinate in integer zurück</returns>
        public int GetFieldX(int aX)
        {
            decimal Column = (decimal)(aX - LocationX) / FieldSize;
            return (int)Math.Ceiling(Column);
        }

        /// <summary>
        /// Berechnet ob die Eingabe gültig ist
        /// </summary>
        /// <param name="aX">Gibt die X Spalte an</param>
        /// <param name="aY">Gibt die Y Spalte an</param>
        /// <returns>true wenn die Eingabe gültig war</returns>
        public bool ValidSpielfeldCoordinate(int aX, int aY)
        {
            return ((aX > LocationX) && (aX < (LocationX + FieldCountX * FieldSize)) && (aY > LocationY) && (aY < (LocationY + FieldCountY * FieldSize)));
        }
    }
}
//Das Zeichnen des Spielfelds und Spieltoken wurde mit Hilfe eines Youtube-Tutorial programmiert --> 4 in Row!
