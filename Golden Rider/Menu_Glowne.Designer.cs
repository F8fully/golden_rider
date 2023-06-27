
namespace Golden_Rider
{
    partial class Menu_Glowne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Glowne));
            this.bstart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bustawienia = new System.Windows.Forms.Button();
            this.bwyjscie = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // bstart
            // 
            this.bstart.BackColor = System.Drawing.Color.Gold;
            this.bstart.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bstart.Location = new System.Drawing.Point(789, 389);
            this.bstart.Name = "bstart";
            this.bstart.Size = new System.Drawing.Size(336, 86);
            this.bstart.TabIndex = 0;
            this.bstart.Text = "Start";
            this.bstart.UseVisualStyleBackColor = false;
            this.bstart.Click += new System.EventHandler(this.bstart_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(660, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 130);
            this.label1.TabIndex = 1;
            this.label1.Text = "Golden Rider";
            // 
            // bustawienia
            // 
            this.bustawienia.BackColor = System.Drawing.Color.Gold;
            this.bustawienia.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bustawienia.Location = new System.Drawing.Point(789, 481);
            this.bustawienia.Name = "bustawienia";
            this.bustawienia.Size = new System.Drawing.Size(336, 86);
            this.bustawienia.TabIndex = 2;
            this.bustawienia.Text = "Ustawienia";
            this.bustawienia.UseVisualStyleBackColor = false;
            this.bustawienia.Click += new System.EventHandler(this.bustawienia_Click);
            // 
            // bwyjscie
            // 
            this.bwyjscie.BackColor = System.Drawing.Color.Gold;
            this.bwyjscie.Font = new System.Drawing.Font("Harlow Solid Italic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bwyjscie.Location = new System.Drawing.Point(789, 573);
            this.bwyjscie.Name = "bwyjscie";
            this.bwyjscie.Size = new System.Drawing.Size(336, 86);
            this.bwyjscie.TabIndex = 3;
            this.bwyjscie.Text = "Wyjscie";
            this.bwyjscie.UseVisualStyleBackColor = false;
            this.bwyjscie.Click += new System.EventHandler(this.bwyjscie_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(0, 0);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.bwyjscie);
            this.Controls.Add(this.bustawienia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bstart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bstart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bustawienia;
        private System.Windows.Forms.Button bwyjscie;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}