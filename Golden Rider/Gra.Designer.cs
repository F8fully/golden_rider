
namespace Golden_Rider
{
    partial class Golden_Rider
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Punkty = new System.Windows.Forms.Label();
            this.Zegar_zdarzeń = new System.Windows.Forms.Timer(this.components);
            this.Beczka2 = new System.Windows.Forms.PictureBox();
            this.Beczka1 = new System.Windows.Forms.PictureBox();
            this.Rider = new System.Windows.Forms.PictureBox();
            this.Podłoże = new System.Windows.Forms.PictureBox();
            this.tPauza = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Beczka2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Beczka1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Podłoże)).BeginInit();
            this.SuspendLayout();
            // 
            // Punkty
            // 
            this.Punkty.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Punkty.Location = new System.Drawing.Point(760, 9);
            this.Punkty.Name = "Punkty";
            this.Punkty.Size = new System.Drawing.Size(762, 238);
            this.Punkty.TabIndex = 5;
            this.Punkty.Text = "Punkty: 0";
            // 
            // Zegar_zdarzeń
            // 
            this.Zegar_zdarzeń.Enabled = true;
            this.Zegar_zdarzeń.Interval = 20;
            this.Zegar_zdarzeń.Tick += new System.EventHandler(this.Zegar_zdarzeń_Tick);
            // 
            // Beczka2
            // 
            this.Beczka2.BackColor = System.Drawing.Color.Transparent;
            this.Beczka2.Image = global::Golden_Rider.Properties.Resources.Beczka2;
            this.Beczka2.Location = new System.Drawing.Point(1708, 697);
            this.Beczka2.Name = "Beczka2";
            this.Beczka2.Size = new System.Drawing.Size(200, 200);
            this.Beczka2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Beczka2.TabIndex = 4;
            this.Beczka2.TabStop = false;
            this.Beczka2.Tag = "przeszkoda";
            // 
            // Beczka1
            // 
            this.Beczka1.BackColor = System.Drawing.Color.Transparent;
            this.Beczka1.Image = global::Golden_Rider.Properties.Resources.Beczka;
            this.Beczka1.Location = new System.Drawing.Point(1003, 750);
            this.Beczka1.Name = "Beczka1";
            this.Beczka1.Size = new System.Drawing.Size(150, 150);
            this.Beczka1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Beczka1.TabIndex = 3;
            this.Beczka1.TabStop = false;
            this.Beczka1.Tag = "przeszkoda";
            // 
            // Rider
            // 
            this.Rider.BackColor = System.Drawing.Color.Transparent;
            this.Rider.Image = global::Golden_Rider.Properties.Resources.Jazda1;
            this.Rider.Location = new System.Drawing.Point(50, 600);
            this.Rider.Margin = new System.Windows.Forms.Padding(0);
            this.Rider.Name = "Rider";
            this.Rider.Size = new System.Drawing.Size(300, 300);
            this.Rider.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rider.TabIndex = 1;
            this.Rider.TabStop = false;
            // 
            // Podłoże
            // 
            this.Podłoże.BackColor = System.Drawing.Color.Black;
            this.Podłoże.Location = new System.Drawing.Point(0, 900);
            this.Podłoże.Margin = new System.Windows.Forms.Padding(0);
            this.Podłoże.Name = "Podłoże";
            this.Podłoże.Size = new System.Drawing.Size(1920, 180);
            this.Podłoże.TabIndex = 0;
            this.Podłoże.TabStop = false;
            // 
            // tPauza
            // 
            this.tPauza.BackColor = System.Drawing.Color.Transparent;
            this.tPauza.Font = new System.Drawing.Font("Harlow Solid Italic", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPauza.Location = new System.Drawing.Point(742, 373);
            this.tPauza.Name = "tPauza";
            this.tPauza.Size = new System.Drawing.Size(316, 162);
            this.tPauza.TabIndex = 6;
            this.tPauza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Golden_Rider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tPauza);
            this.Controls.Add(this.Punkty);
            this.Controls.Add(this.Beczka2);
            this.Controls.Add(this.Beczka1);
            this.Controls.Add(this.Rider);
            this.Controls.Add(this.Podłoże);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Golden_Rider";
            this.Text = "Golden Rider";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Golden_Rider_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Golden_Rider_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Beczka2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Beczka1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Podłoże)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Podłoże;
        private System.Windows.Forms.PictureBox Rider;
        private System.Windows.Forms.PictureBox Beczka1;
        private System.Windows.Forms.PictureBox Beczka2;
        private System.Windows.Forms.Label Punkty;
        private System.Windows.Forms.Timer Zegar_zdarzeń;
        private System.Windows.Forms.Label tPauza;
    }
}

