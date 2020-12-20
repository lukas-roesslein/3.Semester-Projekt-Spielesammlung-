using System;
using System.Windows.Forms;

namespace Spielesammlung
{
    public partial class SchiffeVersenken : Form
    {
        //Konstruktor
        public SchiffeVersenken(string Spieler1, string Spieler2)
        {
            InitializeComponent();
        }

        //Klassen
        class Player    //Bauplan für das Profil eines Spielers
        {
            private int _AnzahlderSchiffeGesammt;   //Gibt die Anzahl der Schiffe an (Größenunabhängig)
            private int _Schiffzähler;  //Um beim platzieren die richtige Anzahl an Schiffen sicher zu stellen
            private int _Anzahlder3FeldSchiffe; //Gibt die Anzahl der 3 Feld großen Schiffe an
            private int _Anzahlder4FeldSchiffe; //Gibt die Anzahl der 4 Feld großen Schiffe an
            private int _Anzahlder5FeldSchiffe; //Gibt die Anzahl der 5 Feld großen Schiffe an

            //VORERST PUBLIC!!!
            public string[,] _SpielfeldDesSpielers = new string[9, 9];  //Erstellt ein Array, welches das Spielfeld eines Spielers repräsentiert
            
            public int AnzahlderSchiffeGesammt  //Zugriff auf die Anzahl der Schiffe
            {
                set { _AnzahlderSchiffeGesammt = value; }
                get { return _AnzahlderSchiffeGesammt; }
            }
            public int Schiffzähler //Zugriff auf die Schiffszähler Variable
            {
                set { _Schiffzähler = value; }
                get { return _Schiffzähler; }
            }
            public int Anzahlder3Schiffe    //Zugriff auf die Anzahl der 3 Feld großen Schiffe an
            {
                set { _Anzahlder3FeldSchiffe = value; }
                get { return _Anzahlder3FeldSchiffe; }
            }
            public int Anzahlder4Schiffe    //Zugriff auf die Anzahl der 4 Feld großen Schiffe an
            {
                set { _Anzahlder4FeldSchiffe = value; }
                get { return _Anzahlder4FeldSchiffe; }
            }
            public int Anzahlder5Schiffe    //Zugriff auf die Anzahl der 5 Feld großen Schiffe an
            {
                set { _Anzahlder5FeldSchiffe = value; }
                get { return _Anzahlder5FeldSchiffe; }
            }
        }
        class Einstellung   //Um einen einzigen Einstellungswert zu verwenden
        {
            private int _Wert;  //Der Wert, den die Einstellung haben soll

            public int Wert //Zugriff auf den Wert
            {
                set { _Wert = value; }
                get { return _Wert; }
            }
        }

        //Instanzieren & Referenzieren der Spieler
        Player Player1 = new Player();  
        Player Player2 = new Player();  

        #region Anzahl der Schiffe festlegen

        //Clickevente
        private void AdS_3_Click(object sender, EventArgs e)
        {
            Player1.AnzahlderSchiffeGesammt = 3; //Legt die Anzahl der Schiffe eines Spielers Fest
            buttonlock_AdS();   //Sperrt und Entsperrt Buttons, gibt im Ausgabe Fenster Text aus und führt Operationen aus
        }

        private void AdS_4_Click(object sender, EventArgs e)
        {
            Player1.AnzahlderSchiffeGesammt = 4;
            buttonlock_AdS();
        }

        private void AdS_5_Click(object sender, EventArgs e)
        {
            Player1.AnzahlderSchiffeGesammt = 5;
            buttonlock_AdS();
        }

        private void AdS_6_Click(object sender, EventArgs e)
        {
            Player1.AnzahlderSchiffeGesammt = 6;
            buttonlock_AdS();
        }

        private void AdS_7_Click(object sender, EventArgs e)
        {
            Player1.AnzahlderSchiffeGesammt = 7;
            buttonlock_AdS();
        }

        private void AdS_8_Click(object sender, EventArgs e)
        {
            Player1.AnzahlderSchiffeGesammt = 8;
            buttonlock_AdS();
        }

        #endregion

        #region Größe der Schiffe festlegen

        private void GdS_3_Click(object sender, EventArgs e)
        {
            Player1.Anzahlder3Schiffe += 1;
            Player2.Anzahlder3Schiffe = Player1.Anzahlder3Schiffe;
            Schiff3FP1.Text = Convert.ToString(Player1.Anzahlder3Schiffe);
            Schiff3FP2.Text = Convert.ToString(Player2.Anzahlder3Schiffe);

            if (SchiffAusgewählt() == 0)
            {

            }
            else
            {
                buttonlock_GdS();
            }
        }

        private void GdS_4_Click(object sender, EventArgs e)
        {
            Player1.Anzahlder4Schiffe += 1;
            Player2.Anzahlder4Schiffe = Player1.Anzahlder4Schiffe;
            Schiff4FP1.Text = Convert.ToString(Player1.Anzahlder4Schiffe);
            Schiff4FP2.Text = Convert.ToString(Player2.Anzahlder4Schiffe);

            if (SchiffAusgewählt() == 0)
            {

            }
            else
            {
                buttonlock_GdS();
            }
        }

        private void GdS_5_Click(object sender, EventArgs e)
        {
            Player1.Anzahlder5Schiffe += 1;
            Player2.Anzahlder5Schiffe = Player1.Anzahlder5Schiffe;
            Schiff5FP1.Text = Convert.ToString(Player1.Anzahlder5Schiffe);
            Schiff5FP2.Text = Convert.ToString(Player2.Anzahlder5Schiffe);

            if (SchiffAusgewählt() == 0)
            {

            }
            else
            {
                buttonlock_GdS();
            }
        }
        #endregion

        #region Schiff platzieren -> horizontal oder vertikal
        Einstellung horizontalvertikal = new Einstellung();

        private void vertikal_Click(object sender, EventArgs e)
        {
            vertikal.BackColor = System.Drawing.Color.Gray;
            horizontal.BackColor = System.Drawing.Color.White;
            horizontalvertikal.Wert = 1;
        }

        private void horizontal_Click(object sender, EventArgs e)
        {
            horizontal.BackColor = System.Drawing.Color.Gray;
            vertikal.BackColor = System.Drawing.Color.White;
            horizontalvertikal.Wert = 2;
        }

        #endregion
        

        private void A11_Click(object sender, EventArgs e)
        {
            if (horizontalvertikal.Wert == 1)
            {
                if(LängedesSchiffes()==3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Player1._SpielfeldDesSpielers[0, i] = "O";
                    }
                }
                if (LängedesSchiffes() == 4)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Player1._SpielfeldDesSpielers[0, i] = "O";
                    }
                }
                if (LängedesSchiffes() == 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Player1._SpielfeldDesSpielers[0, i] = "O";
                    }
                }
                SpielfeldAktualisieren(1);
            }
            else if (horizontalvertikal.Wert == 2)
            {
                if (LängedesSchiffes() == 3)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Player1._SpielfeldDesSpielers[i, 0] = "O";
                    }
                }
                if (LängedesSchiffes() == 4)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Player1._SpielfeldDesSpielers[i, 0] = "O";
                    }
                }
                if (LängedesSchiffes() == 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Player1._SpielfeldDesSpielers[i, 0] = "O";
                    }
                }
            }
            else
            {
                Ausgabe.Text = "Wähle zuerst aus, ob du das Schiff vertikal oder horizontal Platzieren möchtest!";
            }
        }
        
    }
}
