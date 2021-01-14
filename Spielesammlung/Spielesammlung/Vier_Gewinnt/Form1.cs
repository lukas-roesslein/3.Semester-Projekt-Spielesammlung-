using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Gewinnt_Campus_Projekt
{
    /// <summary>
    /// Fenster des Spiels
    /// </summary>
    public partial class TCC : Form
    {
        Spielauswertung Spielauswertung;
        public TCC() : this("Player 1", "Player 2")
        { }
        public TCC(string Name_Player1, string Name_Player2)
        {
            Initialize();
            Name_Player_1.Text = Name_Player1;
            Name_Player_2.Text = Name_Player2;
      
        }


        private void btnNewGame_Click(object sender, EventArgs e)
        {
         

            Spielauswertung = new Spielauswertung();
            Spielauswertung.NewSpiel(this, 7, 6, 70, 155, 100);
            label1.Visible = false;
            label1.Text = "Gewinn Label";
            label3.Text = "Rot";
            label3.ForeColor = System.Drawing.Color.Red;
            label3.Visible = true;
            label2.Visible = true;
            label6.Visible = true;

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Spielauswertung != null)
            {
                Spielauswertung.PlayerClick(e);
                if (Spielauswertung.GetTurn() == 1)
                {
                    label3.Text = "Rot";
                    label3.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    label3.Text = "Gelb";
                    label3.ForeColor = System.Drawing.Color.Yellow;
                }
                if (Spielauswertung.Finish())
                {
                    if (Spielauswertung.GetWinner() == 0)
                        label1.Text = "Unentschieden!";
                    if (Spielauswertung.GetWinner() == 1)
                        label1.Text = Name_Player_1.Text + " hat gewonnen!";
                    if (Spielauswertung.GetWinner() == 2)
                        label1.Text = Name_Player_2.Text + " hat gewonnen!";
                    label1.Visible = true;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Spielauswertung = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void Initialize()
        {
            this.btnNewGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(0, 0);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(100, 28);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "Neues Spiel";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 780);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gewinn Label";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 682);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Am Zug:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(200, 682);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = label1.Text +"= Rot";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 702);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewGame);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vier Gewinnt TCC";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Name_Player_1 = new System.Windows.Forms.Label();
            this.Name_Player_2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name_Player_1
            // 
            this.Name_Player_1.AutoSize = true;
            this.Name_Player_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Player_1.ForeColor = System.Drawing.Color.Red;
            this.Name_Player_1.Location = new System.Drawing.Point(700, 100);
            this.Name_Player_1.Name = "Name_Player_1";
            this.Name_Player_1.Size = new System.Drawing.Size(48, 13);
            this.Name_Player_1.TabIndex = 0;
            this.Name_Player_1.Text = "Spieler 1";
            // 
            // Name_Player_2
            // 
            this.Name_Player_2.AutoSize = true;
            this.Name_Player_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Player_2.ForeColor = System.Drawing.Color.Yellow;
            this.Name_Player_2.Location = new System.Drawing.Point(700, 150);
            this.Name_Player_2.Name = "Name_Player_2";
            this.Name_Player_2.Size = new System.Drawing.Size(48, 13);
            this.Name_Player_2.TabIndex = 1;
            this.Name_Player_2.Text = "Spieler 2";
            // 
            // TCC
            // 
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(897, 738);
            this.Controls.Add(this.Name_Player_2);
            this.Controls.Add(this.Name_Player_1);
            this.Name = "TCC";
            this.ResumeLayout(false);
            this.PerformLayout();

            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(250, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "4-Gewinnt TCC";
            this.label6.Visible = false;


        }
        #endregion

        #region Windows Form Designer generated code

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Name_Player_1;
        private System.Windows.Forms.Label Name_Player_2;
        private System.Windows.Forms.Label label6;






    }
    #endregion
}

