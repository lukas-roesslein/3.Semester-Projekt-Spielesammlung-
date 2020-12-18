using System;
using System.Windows.Forms;

namespace SchiffeVersenken
{
    /// <summary>
    /// Enthält das Spiel "Schiffe versenken"
    /// </summary>
    public partial class SchiffeVersenken : Form
    {
        //Konstruktor
        /// <summary>
        /// Übergibt die Standardnamen der Spieler, wenn kein Name eingegeben wurde
        /// </summary>
        public SchiffeVersenken():this ("Spieler 1", "Spieler 2")
        { }
        /// <summary>
        /// Übergibt die Namen der Spieler, wenn ein Name eingegeben wurde
        /// </summary>
        /// <param name="Name_Player1">Name des 1.Spielers</param>
        /// <param name="Name_Player2">Name des 2.Spielers</param>
        public SchiffeVersenken(string Name_Player1, string Name_Player2)
        {
            InitializeComponent();
            AnzeigePlayer1.Text = Name_Player1;
            AnzeigePlayer2.Text = Name_Player2;
    }

        //Klassen
        /// <summary>
        /// Enthällt allgemeine Daten einer Spielrunde
        /// </summary>
        class GameData
        {
            /// <summary>
            /// Enthällt die Anzahl der Schiffe eines Spielers in einer Spielrunde, unabhängig von der Größe 
            /// </summary>
            private int _AmountOfShipsInTotal;   //Gibt die Anzahl der Schiffe an (Größenunabhängig)
            /// <summary>
            /// Enthällt die Anzahl der 3 Feld großen Schiffe eines Spielers in einer Spielrunde
            /// </summary>
            private int _AmountOfShipsLength3; //Gibt die Anzahl der 3 Feld großen Schiffe an
            /// <summary>
            /// Enthällt die Anzahl der 4 Feld großen Schiffe eines Spielers in einer Spielrunde
            /// </summary>
            private int _AmountOfShipsLength4; //Gibt die Anzahl der 4 Feld großen Schiffe an
            /// <summary>
            /// Enthällt die Anzahl der 5 Feld großen Schiffe eines Spielers in einer Spielrunde
            /// </summary>
            private int _AmountOfShipsLength5; //Gibt die Anzahl der 5 Feld großen Schiffe an
            /// <summary>
            /// set-get von _AmountOfShipsInTotal (Enthällt die Anzahl der Schiffe eines Spielers in einer Spielrunde, unabhängig von der Größe)
            /// </summary>
            public int AmountOfShipsInTotal  //Zugriff auf die Anzahl der Schiffe
            {
                set { _AmountOfShipsInTotal = value; }
                get { return _AmountOfShipsInTotal; }
            }
            /// <summary>
            /// set-get von _AmountOfShipsInTotal (Enthällt die Anzahl der 3 Feld großen Schiffe eines Spielers in einer Spielrunde)
            /// </summary>
            public int AmountOfShipsLength3    //Zugriff auf die Anzahl der 3 Feld großen Schiffe an
            {
                set { _AmountOfShipsLength3 = value; }
                get { return _AmountOfShipsLength3; }
            }
            /// <summary>
            /// set-get von _AmountOfShipsInTotal (Enthällt die Anzahl der 4 Feld großen Schiffe eines Spielers in einer Spielrunde)
            /// </summary>
            public int AmountOfShipsLength4    //Zugriff auf die Anzahl der 4 Feld großen Schiffe an
            {
                set { _AmountOfShipsLength4 = value; }
                get { return _AmountOfShipsLength4; }
            }
            /// <summary>
            /// set-get von _AmountOfShipsInTotal (Enthällt die Anzahl der 5 Feld großen Schiffe eines Spielers in einer Spielrunde)
            /// </summary>
            public int AmountOfShipsLength5    //Zugriff auf die Anzahl der 5 Feld großen Schiffe an
            {
                set { _AmountOfShipsLength5 = value; }
                get { return _AmountOfShipsLength5; }
            }
        }
        /// <summary>
        /// Erstellt die Daten eines Spielers, abgeleitet von den allgemeinen Daten einer Spielrunde
        /// </summary>
        class Player:GameData
        {
            /// <summary>
            /// Ist das Spielfeld (Koordinaten) eines Spielers
            /// </summary>
            public string[,] _BattleArea { get; set; } = new string[9, 9];  //Erstellt ein Array, welches das Spielfeld eines Spielers repräsentiert
        }  
        /// <summary>
        /// Erstellt eine int Variable, die im Laufe des Spiels geändert werden kann
        /// </summary>
        class Property
        {
            /// <summary>
            /// Ist die int Variable die verwendet werden kann
            /// </summary>
            private int _number = 0;  //Der Wert, den die Einstellung haben soll
            /// <summary>
            /// set-get einer Variable 
            /// </summary>
            public int number //Zugriff auf den Wert
            {
                set { _number = value; }
                get { return _number; }
            }
        }

        //Instanzierungen & Referenzierungen
        /// <summary>
        /// Eine erste Spielrunde wird erstellt
        /// </summary>
        GameData counter = new GameData();
        /// <summary>
        /// Spieler1 wird erstellt
        /// </summary>
        Player player1 = new Player();
        /// <summary>
        /// Spieler2 wird erstellt
        /// </summary>
        Player player2 = new Player();
        /// <summary>
        /// Stellt beim Schiffeplatzieren ein ob horizontal oder vertikal platziert werden soll
        /// </summary>
        Property horizontalvertical = new Property();
        /// <summary>
        /// Gibt in welcher Phase sich das Spiel gerade befindet
        /// </summary>
        Property gamestage = new Property();
        /// <summary>
        /// Gibt an welcher Spieler gerade an der Reihe ist
        /// </summary>
        Property turn = new Property(); 
        /// <summary>
        /// Erstellt ein Infofenster
        /// </summary>
        Info infowindow = new Info();

        #region set amount of ships

        private void AdS_3_Click(object sender, EventArgs e)
        {
            player1.AmountOfShipsInTotal = 3; //Legt die Anzahl der Schiffe eines Spielers fest
            AdS_3.BackColor = System.Drawing.Color.Gray;
            buttonlock_AdS();   //Sperrt und Entsperrt Buttons, führt Operationen aus
        }

        private void AdS_4_Click(object sender, EventArgs e)
        {
            player1.AmountOfShipsInTotal = 4;
            AdS_4.BackColor = System.Drawing.Color.Gray;
            buttonlock_AdS();
        }

        private void AdS_5_Click(object sender, EventArgs e)
        {
            player1.AmountOfShipsInTotal = 5;
            AdS_5.BackColor = System.Drawing.Color.Gray;
            buttonlock_AdS();
        }

        private void AdS_6_Click(object sender, EventArgs e)
        {
            player1.AmountOfShipsInTotal = 6;
            AdS_6.BackColor = System.Drawing.Color.Gray;
            buttonlock_AdS();
        }

        private void AdS_7_Click(object sender, EventArgs e)
        {
            player1.AmountOfShipsInTotal = 7;
            AdS_7.BackColor = System.Drawing.Color.Gray;
            buttonlock_AdS();
        }

        private void AdS_8_Click(object sender, EventArgs e)
        {
            player1.AmountOfShipsInTotal = 8;
            AdS_8.BackColor = System.Drawing.Color.Gray;
            buttonlock_AdS();
        }

        #endregion

        #region set length of ships

        private void GdS_3_Click(object sender, EventArgs e)
        {
            player1.AmountOfShipsLength3 += 1; //Spieler 1 definiert 1 Schiff als 3 Koordinaten (Felder) lang
            SetLengthOfShip(3);
        }

        private void GdS_4_Click(object sender, EventArgs e)
        {
            player1.AmountOfShipsLength4 += 1;
            SetLengthOfShip(4);
        }

        private void GdS_5_Click(object sender, EventArgs e)
        {
            player1.AmountOfShipsLength5 += 1;
            SetLengthOfShip(5);
        }

        #endregion

        #region option Buttons (vertical, horizontal placing - turn start, end - game end, restart)

        private void option1_Button_Click(object sender, EventArgs e)
        {
            if (gamestage.number == 0)
            {
                option1_button.BackColor = System.Drawing.Color.Gray; //Button wird grau (ausgewählt)
                option2_button.BackColor = System.Drawing.Color.White;  //anderer Button wird weiß
                horizontalvertical.number = 1;    //Die Einstellung wird als vertikal eingestellt
            }
            else if (gamestage.number == 1)
            {
                if (turn.number == 1)
                {
                    Enablecoordinates(2);
                    Disablecoordinates(1);
                    ShowAllData(1);
                }
                else if (turn.number==2)
                {
                    Enablecoordinates(1);
                    Disablecoordinates(2);
                    ShowAllData(2);
                }
                Ausgabe.Text = "Drücke auf eine Koordinate im gegnerischem Feld um darauf zu schießen.";
            }
            else if (gamestage.number==2)
            {
                Reset();
            }
        }

        private void option2_Button_Click(object sender, EventArgs e)
        {
            if (gamestage.number==0)
            {
                option2_button.BackColor = System.Drawing.Color.Gray;   //Button wird grau (ausgewählt)
                option1_button.BackColor = System.Drawing.Color.White;    //anderer Button wird weiß
                horizontalvertical.number = 2;    //Die Einstellung wird als horizontal eingestellt
            }
            else if (gamestage.number==1)
            {
                HideShips();
                option1_button.Enabled = true;
                option2_button.Enabled = false;
                if(turn.number == 1)
                {
                    turn.number = 2;
                    Ausgabe.Text = Ausgabe.Text + "\n" + AnzeigePlayer2.Text + " ist nun an der Reihe\n " + AnzeigePlayer1.Text + " wegschauen.";
                }
                else if (turn.number == 2)
                {
                    turn.number = 1;
                    Ausgabe.Text = Ausgabe.Text + "\n" + AnzeigePlayer1.Text + " ist nun an der Reihe\nSpieler 2 wegschauen.";
                }
            }
            else if (gamestage.number == 2)
            {
                Close();
            }
        }

        #endregion

        #region clickevents player 1

        private void A11_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0,0,1);
        }

        private void B11_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1,0, 1);
        }

        private void C11_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 0, 1);
        }

        private void D11_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 0, 1);
        }

        private void E11_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 0, 1);
        }

        private void F11_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 0, 1);
        }

        private void G11_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 0, 1);
        }

        private void H11_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 0, 1);
        }

        private void I11_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 0, 1);
        }

        private void A21_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0, 1, 1);
        }

        private void B21_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1, 1, 1);
        }

        private void C21_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 1, 1);
        }

        private void D21_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 1, 1);
        }

        private void E21_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 1, 1);
        }

        private void F21_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 1, 1);
        }

        private void G21_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 1, 1);
        }

        private void H21_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 1, 1);
        }

        private void I21_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 1, 1);
        }

        private void A31_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0, 2, 1);
        }

        private void B31_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1, 2, 1);
        }

        private void C31_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 2, 1);
        }

        private void D31_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 2, 1);
        }

        private void E31_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 2, 1);
        }

        private void F31_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 2, 1);
        }

        private void G31_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 2, 1);
        }

        private void H31_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 2, 1);
        }

        private void I31_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 2, 1);
        }

        private void A41_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0, 3, 1);
        }

        private void B41_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1, 3, 1);
        }

        private void C41_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 3, 1);
        }

        private void D41_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 3, 1);
        }

        private void E41_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 3, 1);
        }

        private void F41_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 3, 1);
        }

        private void G41_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 3, 1);
        }

        private void H41_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 3, 1);
        }

        private void I41_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 3, 1);
        }

        private void A51_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0, 4, 1);
        }

        private void B51_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1, 4, 1);
        }

        private void C51_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 4, 1);
        }

        private void D51_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 4, 1);
        }

        private void E51_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 4, 1);
        }

        private void F51_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 4, 1);
        }

        private void G51_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 4, 1);
        }

        private void H51_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 4, 1);
        }

        private void I51_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 4, 1);
        }

        private void A61_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0, 5, 1);
        }

        private void B61_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1, 5, 1);
        }

        private void C61_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 5, 1);
        }

        private void D61_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 5, 1);
        }

        private void E61_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 5, 1);
        }

        private void F61_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 5, 1);
        }

        private void G61_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 5, 1);
        }

        private void H61_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 5, 1);
        }

        private void I61_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 5, 1);
        }

        private void A71_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0, 6, 1);
        }

        private void B71_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1, 6, 1);
        }

        private void C71_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 6, 1);
        }

        private void D71_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 6, 1);
        }

        private void E71_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 6, 1);
        }

        private void F71_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 6, 1);
        }

        private void G71_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 6, 1);
        }

        private void H71_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 6, 1);
        }

        private void I71_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 6, 1);
        }

        private void A81_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0, 7, 1);
        }

        private void B81_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1, 7, 1);
        }

        private void C81_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 7, 1);
        }

        private void D81_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 7, 1);
        }

        private void E81_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 7, 1);
        }

        private void F81_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 7, 1);
        }

        private void G81_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 7, 1);
        }

        private void H81_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 7, 1);
        }

        private void I81_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 7, 1);
        }

        private void A91_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0, 8, 1);
        }

        private void B91_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1, 8, 1);
        }

        private void C91_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 8, 1);
        }

        private void D91_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 8, 1);
        }

        private void E91_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 8, 1);
        }

        private void F91_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 8, 1);
        }

        private void G91_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 8, 1);
        }

        private void H91_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 8, 1);
        }

        private void I91_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 8, 1);
        }

        #endregion

        #region clickevents player 2

        private void A12_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0, 0, 2);
        }

        private void B12_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1, 0, 2);
        }

        private void C12_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 0, 2);
        }

        private void D12_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 0, 2);
        }

        private void E12_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 0, 2);
        }

        private void F12_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 0, 2);
        }

        private void G12_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 0, 2);
        }

        private void H12_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 0, 2);
        }

        private void I12_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 0, 2);
        }

        private void A22_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0, 1, 2);
        }

        private void B22_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1, 1, 2);
        }

        private void C22_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 1, 2);
        }

        private void D22_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 1, 2);
        }

        private void E22_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 1, 2);
        }

        private void F22_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 1, 2);
        }

        private void G22_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 1, 2);
        }

        private void H22_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 1, 2);
        }

        private void I22_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 1, 2);
        }

        private void A32_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0, 2, 2);
        }

        private void B32_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1, 2, 2);
        }

        private void C32_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 2, 2);
        }

        private void D32_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 2, 2);
        }

        private void E32_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 2, 2);
        }

        private void F32_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 2, 2);
        }

        private void G32_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 2, 2);
        }

        private void H32_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 2, 2);
        }

        private void I32_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 2, 2);
        }

        private void A42_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0, 3, 2);
        }

        private void B42_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1, 3, 2);
        }

        private void C42_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 3, 2);
        }

        private void D42_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 3, 2);
        }

        private void E42_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 3, 2);
        }

        private void F42_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 3, 2);
        }

        private void G42_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 3, 2);
        }

        private void H42_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 3, 2);
        }

        private void I42_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 3, 2);
        }

        private void A52_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0, 4, 2);
        }

        private void B52_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1, 4, 2);
        }

        private void C52_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 4, 2);
        }

        private void D52_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 4, 2);
        }

        private void E52_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 4, 2);
        }

        private void F52_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 4, 2);
        }

        private void G52_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 4, 2);
        }

        private void H52_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 4, 2);
        }

        private void I52_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 4, 2);
        }

        private void A62_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0, 5, 2);
        }

        private void B62_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1, 5, 2);
        }

        private void C62_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 5, 2);
        }

        private void D62_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 5, 2);
        }

        private void E62_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 5, 2);
        }

        private void F62_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 5, 2);
        }

        private void G62_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 5, 2);
        }

        private void H62_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 5, 2);
        }

        private void I62_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 5, 2);
        }

        private void A72_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0, 6, 2);
        }

        private void B72_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1, 6, 2);
        }

        private void C72_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 6, 2);
        }

        private void D72_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 6, 2);
        }

        private void E72_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 6, 2);
        }

        private void F72_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 6, 2);
        }

        private void G72_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 6, 2);
        }

        private void H72_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 6, 2);
        }

        private void I72_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 6, 2);
        }

        private void A82_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0, 7, 2);
        }

        private void B82_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1, 7, 2);
        }

        private void C82_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 7, 2);
        }

        private void D82_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 7, 2);
        }

        private void E82_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 7, 2);
        }

        private void F82_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 7, 2);
        }

        private void G82_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 7, 2);
        }

        private void H82_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 7, 2);
        }

        private void I82_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 7, 2);
        }

        private void A92_Click(object sender, EventArgs e)
        {
            CoordinateScanner(0, 8, 2);
        }

        private void B92_Click(object sender, EventArgs e)
        {
            CoordinateScanner(1, 8, 2);
        }

        private void C92_Click(object sender, EventArgs e)
        {
            CoordinateScanner(2, 8, 2);
        }

        private void D92_Click(object sender, EventArgs e)
        {
            CoordinateScanner(3, 8, 2);
        }

        private void E92_Click(object sender, EventArgs e)
        {
            CoordinateScanner(4, 8, 2);
        }

        private void F92_Click(object sender, EventArgs e)
        {
            CoordinateScanner(5, 8, 2);
        }

        private void G92_Click(object sender, EventArgs e)
        {
            CoordinateScanner(6, 8, 2);
        }

        private void H92_Click(object sender, EventArgs e)
        {
            CoordinateScanner(7, 8, 2);
        }

        private void I92_Click(object sender, EventArgs e)
        {
            CoordinateScanner(8, 8, 2);
        }

        #endregion

        #region menu bar
        private void spielBeendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void spielBeendenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infowindow.Show();
        }

        #endregion
    }
}
