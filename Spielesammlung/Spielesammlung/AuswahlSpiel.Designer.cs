
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
            this.L_Name1 = new System.Windows.Forms.Label();
            this.L_Name2 = new System.Windows.Forms.Label();
            this.TB_Name1 = new System.Windows.Forms.TextBox();
            this.TB_Name2 = new System.Windows.Forms.TextBox();
            this.CB_NameSpiel = new System.Windows.Forms.ComboBox();
            this.B_Start = new System.Windows.Forms.Button();
            this.L_Titel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welches Spiel möchtest du spielen?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // L_Name1
            // 
            this.L_Name1.AutoSize = true;
            this.L_Name1.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Name1.Location = new System.Drawing.Point(119, 197);
            this.L_Name1.Name = "L_Name1";
            this.L_Name1.Size = new System.Drawing.Size(184, 32);
            this.L_Name1.TabIndex = 4;
            this.L_Name1.Text = "Name Spieler 1:";
            // 
            // L_Name2
            // 
            this.L_Name2.AutoSize = true;
            this.L_Name2.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Name2.Location = new System.Drawing.Point(119, 257);
            this.L_Name2.Name = "L_Name2";
            this.L_Name2.Size = new System.Drawing.Size(184, 32);
            this.L_Name2.TabIndex = 5;
            this.L_Name2.Text = "Name Spieler 2:";
            // 
            // TB_Name1
            // 
            this.TB_Name1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Name1.Location = new System.Drawing.Point(370, 197);
            this.TB_Name1.Name = "TB_Name1";
            this.TB_Name1.Size = new System.Drawing.Size(265, 38);
            this.TB_Name1.TabIndex = 6;
            // 
            // TB_Name2
            // 
            this.TB_Name2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Name2.Location = new System.Drawing.Point(370, 257);
            this.TB_Name2.Name = "TB_Name2";
            this.TB_Name2.Size = new System.Drawing.Size(265, 38);
            this.TB_Name2.TabIndex = 7;
            // 
            // CB_NameSpiel
            // 
            this.CB_NameSpiel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_NameSpiel.FormattingEnabled = true;
            this.CB_NameSpiel.Items.AddRange(new object[] {
            "TIC TAC TOE",
            "Vier Gewinnt",
            "Schiffe Versenken",
            "Cross Game"});
            this.CB_NameSpiel.Location = new System.Drawing.Point(59, 438);
            this.CB_NameSpiel.Name = "CB_NameSpiel";
            this.CB_NameSpiel.Size = new System.Drawing.Size(348, 37);
            this.CB_NameSpiel.TabIndex = 8;
            this.CB_NameSpiel.Text = "Bitte ein Spiel auswählen...";
            // 
            // B_Start
            // 
            this.B_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_Start.Location = new System.Drawing.Point(483, 542);
            this.B_Start.Name = "B_Start";
            this.B_Start.Size = new System.Drawing.Size(152, 50);
            this.B_Start.TabIndex = 9;
            this.B_Start.Text = "START";
            this.B_Start.UseVisualStyleBackColor = true;
            this.B_Start.Click += new System.EventHandler(this.B_Start_Click);
            // 
            // L_Titel
            // 
            this.L_Titel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.L_Titel.AutoSize = true;
            this.L_Titel.Font = new System.Drawing.Font("MV Boli", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Titel.Location = new System.Drawing.Point(241, 26);
            this.L_Titel.Name = "L_Titel";
            this.L_Titel.Size = new System.Drawing.Size(321, 52);
            this.L_Titel.TabIndex = 10;
            this.L_Titel.Text = "Spielesammlung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bitte Namen eingeben:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AuswahlSpiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L_Titel);
            this.Controls.Add(this.B_Start);
            this.Controls.Add(this.CB_NameSpiel);
            this.Controls.Add(this.TB_Name2);
            this.Controls.Add(this.TB_Name1);
            this.Controls.Add(this.L_Name2);
            this.Controls.Add(this.L_Name1);
            this.Controls.Add(this.label1);
            this.Name = "AuswahlSpiel";
            this.Text = "AuswahlSpiel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label L_Name1;
        private System.Windows.Forms.Label L_Name2;
        private System.Windows.Forms.TextBox TB_Name1;
        private System.Windows.Forms.TextBox TB_Name2;
        private System.Windows.Forms.ComboBox CB_NameSpiel;
        private System.Windows.Forms.Button B_Start;
        private System.Windows.Forms.Label L_Titel;
        private System.Windows.Forms.Label label2;
    }
}