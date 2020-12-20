
namespace Spielesammlung
{
    partial class AuswahlSpiel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.B_TicTacToe = new System.Windows.Forms.Button();
            this.B_VierGewinnt = new System.Windows.Forms.Button();
            this.B_Schiffeversenken = new System.Windows.Forms.Button();
            this.L_Name1 = new System.Windows.Forms.Label();
            this.L_Name2 = new System.Windows.Forms.Label();
            this.TB_Name1 = new System.Windows.Forms.TextBox();
            this.TB_Name2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welches Spiel möchtest du spielen?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // B_TicTacToe
            // 
            this.B_TicTacToe.Location = new System.Drawing.Point(12, 288);
            this.B_TicTacToe.Name = "B_TicTacToe";
            this.B_TicTacToe.Size = new System.Drawing.Size(215, 101);
            this.B_TicTacToe.TabIndex = 1;
            this.B_TicTacToe.Text = "Tic Tac Toe";
            this.B_TicTacToe.UseVisualStyleBackColor = true;
            this.B_TicTacToe.Click += new System.EventHandler(this.B_TicTacToe_Click);
            // 
            // B_VierGewinnt
            // 
            this.B_VierGewinnt.Location = new System.Drawing.Point(289, 288);
            this.B_VierGewinnt.Name = "B_VierGewinnt";
            this.B_VierGewinnt.Size = new System.Drawing.Size(215, 101);
            this.B_VierGewinnt.TabIndex = 2;
            this.B_VierGewinnt.Text = "Vier Gewinnt";
            this.B_VierGewinnt.UseVisualStyleBackColor = true;
            this.B_VierGewinnt.Click += new System.EventHandler(this.B_VierGewinnt_Click);
            // 
            // B_Schiffeversenken
            // 
            this.B_Schiffeversenken.Location = new System.Drawing.Point(573, 288);
            this.B_Schiffeversenken.Name = "B_Schiffeversenken";
            this.B_Schiffeversenken.Size = new System.Drawing.Size(215, 101);
            this.B_Schiffeversenken.TabIndex = 3;
            this.B_Schiffeversenken.Text = "Schiffe versenken";
            this.B_Schiffeversenken.UseVisualStyleBackColor = true;
            this.B_Schiffeversenken.Click += new System.EventHandler(this.B_Schiffeversenken_Click);
            // 
            // L_Name1
            // 
            this.L_Name1.AutoSize = true;
            this.L_Name1.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Name1.Location = new System.Drawing.Point(96, 113);
            this.L_Name1.Name = "L_Name1";
            this.L_Name1.Size = new System.Drawing.Size(184, 32);
            this.L_Name1.TabIndex = 4;
            this.L_Name1.Text = "Name Spieler 1:";
            // 
            // L_Name2
            // 
            this.L_Name2.AutoSize = true;
            this.L_Name2.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Name2.Location = new System.Drawing.Point(96, 173);
            this.L_Name2.Name = "L_Name2";
            this.L_Name2.Size = new System.Drawing.Size(184, 32);
            this.L_Name2.TabIndex = 5;
            this.L_Name2.Text = "Name Spieler 2:";
            // 
            // TB_Name1
            // 
            this.TB_Name1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Name1.Location = new System.Drawing.Point(347, 113);
            this.TB_Name1.Name = "TB_Name1";
            this.TB_Name1.Size = new System.Drawing.Size(265, 38);
            this.TB_Name1.TabIndex = 6;
            // 
            // TB_Name2
            // 
            this.TB_Name2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Name2.Location = new System.Drawing.Point(347, 173);
            this.TB_Name2.Name = "TB_Name2";
            this.TB_Name2.Size = new System.Drawing.Size(265, 38);
            this.TB_Name2.TabIndex = 7;
            // 
            // AuswahlSpiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB_Name2);
            this.Controls.Add(this.TB_Name1);
            this.Controls.Add(this.L_Name2);
            this.Controls.Add(this.L_Name1);
            this.Controls.Add(this.B_Schiffeversenken);
            this.Controls.Add(this.B_VierGewinnt);
            this.Controls.Add(this.B_TicTacToe);
            this.Controls.Add(this.label1);
            this.Name = "AuswahlSpiel";
            this.Text = "AuswahlSpiel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_TicTacToe;
        private System.Windows.Forms.Button B_VierGewinnt;
        private System.Windows.Forms.Button B_Schiffeversenken;
        private System.Windows.Forms.Label L_Name1;
        private System.Windows.Forms.Label L_Name2;
        private System.Windows.Forms.TextBox TB_Name1;
        private System.Windows.Forms.TextBox TB_Name2;
    }
}