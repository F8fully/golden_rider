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
    public partial class Golden_Rider : Form
    {
        bool skok = false;                      // Funkcja boolowska sprawdzająca wyskok
        int szybkosc_skoku = 80;                // Prędkość wyskoku
        int sila_skoku = 400;                   // Siła wyskoku
        int punkty = 0;                         // Podstawowy wynik
        int predkosc_przeszkody = 15;           // Podstawowa prędkość przeszkód
        Random rnd = new Random();              // Nowa klasa pseudolosowa

        public Golden_Rider()
        {
            InitializeComponent();
            Restart_Gry();
            Zegar_zdarzeń.Stop();                 
        }

        public void Zatrzymanie_Gry()
        {
            Zegar_zdarzeń.Stop();               // Zapauzowanie eventu
            tPauza.Text = "Pauza";
        }

        public void Wznowienie_Gry()
        {
            Zegar_zdarzeń.Start();              // Wznowienie eventu
            tPauza.Text = "";
        }

        public void Restart_Gry()               // Funkcja Restartująca Gre
        {
            sila_skoku = 400;                       // Ustawaimy wartość siły
            Rider.Top = Podłoże.Top - Rider.Height; // Kładziemy ridera na podłożu
            szybkosc_skoku = 0;                     // Ustawiamy szybkość skoku
            skok = false;                           // Zmieniamy wartość skoku
            punkty = 0;                             // Zerujemy Punkty
            predkosc_przeszkody = 15;               // Zmieniamy prędkość przeszkód
            Punkty.Text = "Punkty: " + punkty;      // Resertujemy textboxa z punktami

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "przeszkoda")   // Kiedy x jest Obrazkiem otagowanym jako przeszkoda
                {                  
                    int position = rnd.Next(800, 1200);                 // Randomowa pozycja przeszkody z poza ekranu
                    x.Left = 640 + (x.Left + position + x.Width * 3);   // Zmiana pozycji przeszkody przy kolejnej rundzie

                }
            }

            Zegar_zdarzeń.Start();                  // Zaczęcie eventu
        }

        private void Golden_Rider_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)                       //Zamykanie formuły ESC
            {
                this.Hide();
                Zatrzymanie_Gry();
            }

            if (e.KeyCode == Keys.Space && !skok)               //Sprawdzamy położenie spacji i wartości funkji skok i ją zmieniamy 
            {
                skok = true;
                Rider.Image = Properties.Resources.Skok;
            }

        }

        private void Golden_Rider_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                Restart_Gry();                                  //Dla wciśniętego przycisku R restartujemy Gre
            }

            if (e.KeyCode == Keys.P)
            {
                Zatrzymanie_Gry();
            }

            if (e.KeyCode == Keys.S)
            {
                Wznowienie_Gry();
            }

            if (skok)                                           //Zmiana wartości skok jeśli puścimy spacje
            {
                skok = false;
                Rider.Image = Properties.Resources.Jazda1;
            }
        }

        private void Zegar_zdarzeń_Tick(object sender, EventArgs e)
        {
            Rider.Top += szybkosc_skoku;                        //Przypisuje wartość wyskoku do Ridera
            Punkty.Text = "Punkty: " + punkty;                  //Pokazuje wartość punktacji

            if (skok && sila_skoku < 0)                         //Zmieniamy wartość skoku przy sile mniejszej od zera i wciśnietaj spacji
            {
                skok = false;
                Rider.Image = Properties.Resources.Skok;
            }

            if (skok)                                           //Jeśli wartość skoku jest prawdziwa to redukujemy parametry wyskoku
            {
                szybkosc_skoku = -12;
                sila_skoku -= 1;
            }

            else
            {
                szybkosc_skoku = 12;                            //Inaczej zostawiamy wartości podstawowe
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "przeszkoda")       // Kiedy x jest Obrazkiem otagowanym jako przeszkoda
                {
                    x.Left -= predkosc_przeszkody;                          // Poruszamy przeszkode w strone Ridera

                    if (x.Left + x.Width < 0)                                       // Jeśli przeszkoda wyleci poza ekran
                    {
                        x.Left = this.ClientSize.Width + rnd.Next(400, 800);        // Respawnujemy ją w randomowym miejscu poza ekranem z prawej strony
                        punkty++;                                                   // Dodajemy punkt
                    }

                    if (Rider.Bounds.IntersectsWith(x.Bounds))                      // Jeśli Rider uderzy sie z beczkami
                    {
                        Zegar_zdarzeń.Stop();                                       //Zatrzymujemy zegar żeby zresetować gre
                        Punkty.Text += "  Press R to restart";
                    }
                }
            }

            if (Rider.Top >= 600 && !skok)                                  // Jeśli Wysokość Ridera osiągnie poziom a skok jest zanegowany
            {
                sila_skoku = 400;                                           // Ustawiamy siłe wyskoku
                Rider.Top = Podłoże.Top - Rider.Height;                     // Kładziemy Ridera na Podłożu
                szybkosc_skoku = 0;                                         // Szybkość skoku ustawiamy na zero
            }

            if (punkty >= 10)                                               // Utrudniamy gre gdy mamy ponad 10 punktów
            {
                predkosc_przeszkody = 20;                                   // Zmieniamy prędkość przeszkody
            }

            if (Rider.Top < Podłoże.Top - Rider.Height && !skok)                     // Dla ridera w wykoku zmieniamy teksture na wyskok
            {
                Rider.Image = Properties.Resources.Skok;
            }

            else                                                            // Dla ridera jadącego zmieniamy teksture na jazde
            {
                Rider.Image = Properties.Resources.Jazda1;
            }
        }
    }
}
