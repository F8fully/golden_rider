using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace Golden_Rider
{
    public partial class Menu_Glowne : Form
    {
        Golden_Rider start = new Golden_Rider();
        Ustawiena u_pokaz = new Ustawiena();

        public Menu_Glowne()
        {
            InitializeComponent();
            muzyczka.URL = @"D:\Moje Pliki\Szkoła\4)Politechnika Wrocławska\Semestr 3\Programowanie_aplikacyjne_P\cw9\Muzyka\Need for Speed Tribute - Nine Thou (Grant Mohrman Superstars Remix) by Styles of Beyond.mp3";
        }
        public static WMPLib.WindowsMediaPlayer muzyczka = new WMPLib.WindowsMediaPlayer();

        private void Menu_Load(object sender, EventArgs e)
        {   
            muzyczka.controls.play();
        }

        private void bstart_Click(object sender, EventArgs e)
        {
            start.Show();
            start.Wznowienie_Gry();
        }

        private void bustawienia_Click(object sender, EventArgs e)
        {
            u_pokaz.Show();
        }

        private void bwyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
