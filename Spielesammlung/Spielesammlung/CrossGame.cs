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
    public partial class CrossGame : Form               // CrossGame abgeleitet von der Basis Form
    {
        bool moveLeft, moveRight, moveUp, moveDown;      // boolsche Variablen die benutzt werden, um sich in bestimmte Richtungen zu bewegen
        int speed = 15;                                  // Variable für die Geschwindigkeit 
        int Goldworth = 0;                               // Wert der Goldnuggets


        #region
        /// <summary>
        /// Basis Konstruktor 
        /// </summary>
        public CrossGame()                  // Konstruktor dieser Form
        {
            InitializeComponent();       
            GameReset();
            End.Visible = false;  // Game over Label zu beginn unsichtbar
            Winning.Visible = false;  // Win Label zu beginn unsichtbar 
            labelRetry.Visible = false;    //Retry Label zu beginn unsichtbar 
            Save1.Visible = true;        //Methode des GameReset immer vorhanden damit jederzeit resetet werden kann
            lblmax.Visible = false;
            
        }
        #endregion 

        #region
        /// <summary>
        /// Methode damit überprüft wird ob der Spieler gewonnen hat oder nicht 
        /// <para> Solange weniger als 3 Nuggets eingesammelt wurden kann der Spieler nicht gewinnen
        /// </para>
        /// </summary>
        void Sieg()
        {
            
            if (Player.Bounds.IntersectsWith(Save2.Bounds))
            {
                if (Goldworth <=3)                // weder Gewonnen noch Verloren das Spiel geht weiter
                {
                    Winning.Visible = false;
                    timer1.Enabled = true;
                    labelRetry.Visible = false;
                    Player.Visible = true;
                }
                if (Goldworth >=7)             // Maximale Punktzahl
                {
                
                    lblmax.Visible = true;
                    timer1.Enabled = false;
                    Winning.Visible = false;
                    Player.Visible = false;
                    End.Visible = false;
                    labelRetry.Visible = true;
                }
                if(Goldworth >3 && Goldworth< 7)         // Gewonnen  
                {
                           timer1.Enabled = false;
                           Winning.Visible = true;
                           Player.Visible = false;
                           End.Visible = false;
                           labelRetry.Visible = true;
                }


            }
            
        }
        #endregion

        #region
        /// <summary>
        /// Methode zur Bestimmmung des Gameover
        /// <para> Mittels Kollision der Grenzen 
        /// <value> Die Eigenschaft Visible sorgt, mittels den boolschen Wert true, dafür ,dass das Label sichtbar wird
        /// </value>
        /// </para>
        /// </summary>
        void GameOver()
        {

            if (Player.Bounds.IntersectsWith(Enemyd1.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyd2.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyd3.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyd4.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyd5.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyd6.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyu1.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyu2.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyu3.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyu4.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyu5.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(Enemyu6.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(EnemyR1.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }

            if (Player.Bounds.IntersectsWith(EnemyL1.Bounds))
            {
                timer1.Enabled = false;
                End.Visible = true;
                Player.Visible = false;
                labelRetry.Visible = true;
            }


        }
        #endregion

        #region
        /// <summary>
        /// Methode für den Reset 
        /// <value>
        /// Alle eingesammelten Nuggets werden wieder sichtbar, zudem ist der score auf 0 
        /// </value>
        /// </summary>
        private void GameReset()
        {
            Goldworth = 1;
            Player.Top = 240;
            Player.Left = 615;
            Points.Text = "score: 0";
            Gold1.Visible = true;
            Gold2.Visible = true;
            Gold3.Visible = true;
            Gold4.Visible = true;
            Gold5.Visible = true;
            Gold6.Visible = true;
            Gold7.Visible = true;
        }
        #endregion

        #region

        /// <summary>
        /// Methode, die für die Bewegung der Gegner benutzt wird 
        /// </summary>
        /// <value>
        /// Solange Gegner Grenzen größer, kleiner oder gleich von einer bestimmten Pixelanzahl sind kann ein sogenanntes scrolling hervorgerufen werden
        /// </value>
        /// <param name="Speed"> 
        /// Variable für die Geschwindigkeit
        /// </param>
        void Enemy(int Speed)
        {
            if (Enemyd1.Top >= 426)
            { Enemyd1.Top = 27; }
            else { Enemyd1.Top += Speed; }

            if (Enemyd2.Top >= 426)
            { Enemyd2.Top = 27; }
            else { Enemyd2.Top += Speed; }

            if (Enemyd3.Top >= 426)
            { Enemyd3.Top = 27; }
            else { Enemyd3.Top += Speed; }

            if (Enemyd4.Top >= 426)
            { Enemyd4.Top = 27; }
            else { Enemyd4.Top += Speed; }

            if (Enemyd5.Top >= 426)                           //Enemys going down
            { Enemyd5.Top = 27; }
            else { Enemyd5.Top += Speed; }

            if (Enemyd6.Top >= 426)
            { Enemyd6.Top = 27; }
            else { Enemyd6.Top += Speed; }



            if (Enemyu1.Bottom <= 27)
            { Enemyu1.Top = 426; }
            else { Enemyu1.Top -= Speed; }

            if (Enemyu2.Bottom <= 27)
            { Enemyu2.Top = 426; }
            else { Enemyu2.Top -= Speed; }

            if (Enemyu3.Bottom <= 27)
            { Enemyu3.Top = 426; }                           //Enemys going up
            else { Enemyu3.Top -= Speed; }

            if (Enemyu4.Bottom <= 27)
            { Enemyu4.Top = 426; }
            else { Enemyu4.Top -= Speed; }

            if (Enemyu5.Bottom <= 27)
            { Enemyu5.Top = 426; }
            else { Enemyu5.Top -= Speed; }

            if (Enemyu6.Bottom <= 27)
            { Enemyu6.Top = 426; }
            else { Enemyu6.Top -= Speed; }


            if (EnemyL1.Left >= 666)
            { EnemyL1.Left = 0; }
            else { EnemyL1.Left += Speed; }         // Enemys going sideways 

            if (EnemyR1.Left <= 0)
            { EnemyR1.Left = 666; }
            else { EnemyR1.Left -= Speed; }
        }
        #endregion

        #region
        /// <summary>
        /// Methode um den Punktestand zu ermitteln bzw zu erhöhen 
        /// <value>
        /// Wenn die jeweilige Picturebox(Goldnugget) berührt wird, wird es unsichtbar
        /// </value>
        /// </summary>
        
        void Score()
        {
            foreach( Control x in this.Controls) // für jedes control(taste gedrückt) in x Richtung
            {
                if (x is PictureBox && ( string) x.Tag == "object" ) // sofern in diesem x eine Picturebox ist und in dem tag object steht 
                {
                    
                       if (Player.Bounds.IntersectsWith(x.Bounds)&& x.Visible == Visible) // und wenn der Spieler mit dem x kollidiert
                        {

                           // dann soll der Wert der Variable Goldworth inkrementiert werden und zu einem string konvertiert werden
                            Points.Text = "score: 0" + Goldworth.ToString(); 
                            Goldworth++; 
                         

                        }
                   
                        
                   
                }
            }
            if (Player.Bounds.IntersectsWith(Gold1.Bounds)) // Wenn Grenzen des Spielers und der goldenen Picturebox(Gold1) kollidieren
            {
                Gold1.Visible = false;                  // dann soll dieses unsichtbar werden 
            }
          
            if (Player.Bounds.IntersectsWith(Gold2.Bounds))// Wenn Grenzen des Spielers und der goldenen Picturebox(Gold2) kollidieren

            {
                Gold2.Visible = false;                   // dann soll dieses unsichtbar werden 
            }

            if (Player.Bounds.IntersectsWith(Gold3.Bounds))// Wenn Grenzen des Spielers und der goldenen Picturebox(Gold3) kollidieren

            {
                Gold3.Visible = false;                  // dann soll dieses unsichtbar werden 
            }

            if (Player.Bounds.IntersectsWith(Gold4.Bounds))// Wenn Grenzen des Spielers und der goldenen Picturebox(Gold4) kollidieren

            {
                Gold4.Visible = false;                  // dann soll dieses unsichtbar werden 
            }

            if (Player.Bounds.IntersectsWith(Gold5.Bounds))// Wenn Grenzen des Spielers und der goldenen Picturebox(Gold5) kollidieren

            {
                Gold5.Visible = false;                  // dann soll dieses unsichtbar werden 
            }

            if (Player.Bounds.IntersectsWith(Gold6.Bounds))// Wenn Grenzen des Spielers und der goldenen Picturebox(Gold6) kollidieren

            {
                Gold6.Visible = false;                 // dann soll dieses unsichtbar werden 
            }

            if (Player.Bounds.IntersectsWith(Gold7.Bounds))// Wenn Grenzen des Spielers und der goldenen Picturebox(Gold7) kollidieren

            {

                Gold7.Visible = false;                  // dann soll dieses unsichtbar werden 
            }
        }
        #endregion


        #region

        /// <summary>
        /// Methode um sich in alle Richtungen zu bewegen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (moveLeft == true && Player.Left > 0)             // BoolVariable ist true und linke grenze von Player gräßer Null 
            {
                Player.Left -= speed;                            // -= Operator da Spieler in Richtung (-) x-Achse 
            }

            if (moveRight == true && Player.Left < 625)
            {
                Player.Left += speed;
            }
            if (moveUp == true && Player.Top > 82)
            {
                Player.Top -= speed;
            }
            if (moveDown == true && Player.Top < 401)
            {
                Player.Top += speed;
            }


            
        



            Enemy(10);
            GameOver();
            Sieg();
            Score();
            
        }

        #endregion


        #region
        /// <summary>
        /// Methode um fest zu legen was geschieht wenn Pfeiltasten nicht gedrückt sind 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CrossGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)                  // Tastencode gleich Pfeiltaste Links
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)                 // Tastencode gleich Pfeiltaste Rechts
            {
                moveRight = false;
            }

            if (e.KeyCode == Keys.Up)                    // Tastencode gleich Pfeiltaste Oben
            {
                moveUp = false;
            }
            if (e.KeyCode == Keys.Down)                    // Tastencode gleich Pfeiltaste Unten
            {
                moveDown = false;
            }
        }
        #endregion

        #region

        /// <summary>
        /// Methode um fest zu legen was geschieht wenn Pfeiltasten oder Entertaste gedrückt sind 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CrossGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)                  // Tastencode gleich Pfeiltaste Links
            {
                moveLeft = true;
            }
            if (e.KeyCode == Keys.Right)                 // Tastencode gleich Pfeiltaste Rechts
            {
                moveRight = true;
            }

            if (e.KeyCode == Keys.Up)                    // Tastencode gleich Pfeiltaste Oben
            {
                moveUp = true;
            }
            if (e.KeyCode == Keys.Down)                    // Tastencode gleich Pfeiltaste Unten
            {
                moveDown = true;
            }



            if (e.KeyCode == Keys.Enter)       // überprüfung ob Entertaste gedrückt wurde 

            {



                if (End.Visible || Winning.Visible ||lblmax.Visible == true)  // Falls  Win- oder Gameover-Sequenz eintritt und Entertaste gedrückt wird tritt folgendes ein

                {


                    End.Visible = false;                       // Gameover-Sequenz wird unsichtbar
                    Winning.Visible = false;                   // Gameover-Sequenz wird unsichtbar
                    timer1.Enabled = true;                     // Timer ist true damit sich Gegner weiter bewegen
                    lblmax.Visible = false;                    // Maximum score ist unsichtbar
                    Player.Visible = true;                     // Der Player ist Sichtbar 
                    labelRetry.Visible = true;                 // Retry label ist sichtbar




                    if (e.KeyCode == Keys.Enter)         //Sofern Spiel gewonnen oder verloren wurde kann mit der Entertaste das Spiel resetet werden.
                    {                                    //Damit kann das Spiel schneller wieder begonnen werden. Spiel wird flüssiger.
                        labelRetry.Visible = false;      //Das Label Retry wird nicht mehr sichtbar.
                        GameReset();                     //Methode um das Spiel zu reseten.
                    }



                }

            }
        }
        #endregion

        #region
        /// <summary>
        /// Methode für ein Untermenü der Hauptmenüleiste an dem oberen Rand des Forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spielVerlassenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // Wenn auf der Grafischen Oberfläche im oberen linken Eck auf Spielverlassen geklickt wird soll sich dieses Fenster schließen
        }
        #endregion


        #region
        /// <summary>
        /// Methode für ein Untermenü der Hauptmenüleiste an dem oberen Rand des Forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void neuesSpielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameReset();  // Wenn auf der Grafischen Oberfläche im oberen linken Eck auf neues Spiel geklickt wird soll sich dieses Fenster reseten
        }
        #endregion
    }
}
