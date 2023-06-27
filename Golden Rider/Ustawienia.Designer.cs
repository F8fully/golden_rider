
namespace Golden_Rider
{
    partial class Ustawiena
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
            this.glosnosc = new System.Windows.Forms.TrackBar();
            this.Dzwięk = new System.Windows.Forms.TextBox();
            this.ikona_dzwieku = new System.Windows.Forms.PictureBox();
            this.Sterowanie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.glosnosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikona_dzwieku)).BeginInit();
            this.SuspendLayout();
            // 
            // glosnosc
            // 
            this.glosnosc.BackColor = System.Drawing.Color.Gold;
            this.glosnosc.Location = new System.Drawing.Point(766, 378);
            this.glosnosc.Maximum = 50;
            this.glosnosc.Name = "glosnosc";
            this.glosnosc.Size = new System.Drawing.Size(209, 45);
            this.glosnosc.TabIndex = 0;
            this.glosnosc.Scroll += new System.EventHandler(this.glosnosc_Scroll);
            this.glosnosc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glosnosc_KeyDown);
            // 
            // Dzwięk
            // 
            this.Dzwięk.BackColor = System.Drawing.Color.Gold;
            this.Dzwięk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dzwięk.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dzwięk.Location = new System.Drawing.Point(766, 266);
            this.Dzwięk.Name = "Dzwięk";
            this.Dzwięk.ReadOnly = true;
            this.Dzwięk.Size = new System.Drawing.Size(209, 81);
            this.Dzwięk.TabIndex = 1;
            this.Dzwięk.Text = "Dzwiek";
            this.Dzwięk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Dzwięk.TextChanged += new System.EventHandler(this.Dzwięk_TextChanged);
            // 
            // ikona_dzwieku
            // 
            this.ikona_dzwieku.Image = global::Golden_Rider.Properties.Resources.sound_on;
            this.ikona_dzwieku.Location = new System.Drawing.Point(1000, 253);
            this.ikona_dzwieku.Name = "ikona_dzwieku";
            this.ikona_dzwieku.Size = new System.Drawing.Size(200, 200);
            this.ikona_dzwieku.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ikona_dzwieku.TabIndex = 2;
            this.ikona_dzwieku.TabStop = false;
            this.ikona_dzwieku.Click += new System.EventHandler(this.ikona_dzwieku_Click);
            this.ikona_dzwieku.DoubleClick += new System.EventHandler(this.ikona_dzwieku_DoubleClick);
            // 
            // Sterowanie
            // 
            this.Sterowanie.BackColor = System.Drawing.Color.Gold;
            this.Sterowanie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Sterowanie.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sterowanie.Location = new System.Drawing.Point(634, 459);
            this.Sterowanie.Multiline = true;
            this.Sterowanie.Name = "Sterowanie";
            this.Sterowanie.ReadOnly = true;
            this.Sterowanie.Size = new System.Drawing.Size(681, 517);
            this.Sterowanie.TabIndex = 3;
            this.Sterowanie.Text = "Sterowanie:\r\nESC - Wstecz/Zamknij\r\nR - Restart\r\nP - Pauza\r\nS - Start\r\nSpacja - Sk" +
    "ok";
            this.Sterowanie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sterowanie.TextChanged += new System.EventHandler(this.Sterowanie_TextChanged);
            // 
            // Ustawiena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Sterowanie);
            this.Controls.Add(this.ikona_dzwieku);
            this.Controls.Add(this.Dzwięk);
            this.Controls.Add(this.glosnosc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ustawiena";
            this.Text = "Ustawiena";
            ((System.ComponentModel.ISupportInitialize)(this.glosnosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ikona_dzwieku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar glosnosc;
        private System.Windows.Forms.TextBox Dzwięk;
        private System.Windows.Forms.PictureBox ikona_dzwieku;
        private System.Windows.Forms.TextBox Sterowanie;
    }
}