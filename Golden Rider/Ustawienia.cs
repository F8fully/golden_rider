using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golden_Rider
{
    public partial class Ustawiena : Form
    {

        public Ustawiena()
        {
            InitializeComponent();
        }

        private void glosnosc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)                       //Zamykanie formuły ESC
            {
                this.Hide();
            }
        }

        private void glosnosc_Scroll(object sender, EventArgs e)
        {
            Menu_Glowne.muzyczka.controls.play();
            Menu_Glowne.muzyczka.settings.volume = glosnosc.Value;
            ikona_dzwieku.Image = Properties.Resources.sound_on;

            if (glosnosc.Value == 0)
            {
                ikona_dzwieku.Image = Properties.Resources.sound_off;
            }

        }

        private void ikona_dzwieku_Click(object sender, EventArgs e)
        {
            Menu_Glowne.muzyczka.settings.volume = 0;
            ikona_dzwieku.Image = Properties.Resources.sound_off;
        }

        private void ikona_dzwieku_DoubleClick(object sender, EventArgs e)
        {
            Menu_Glowne.muzyczka.settings.volume = glosnosc.Value;
            ikona_dzwieku.Image = Properties.Resources.sound_on;
        }

        private void Sterowanie_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dzwięk_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
