using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_2
{
    public partial class Form1 : Form
    {
        Chart wykres = new Chart();
        private Button a;       //aktywny przycisk
        private Harmonogram har;
        private int metoda=3;   //wybór metody mieszania zadań w harmonogamie
        private string sciezka = "D:\\STUDIA\\SEMESTR 9 2014 - MGR\\OPTYMALIZACJA\\Optymalizacja_2\\dane\\NEH";

        public Form1()
        {
            InitializeComponent();
            har = new Harmonogram();
            resetParametrow();
            wykres.Show();
        }

        //resetuje parametry algorytmu SA
        private void resetParametrow()
        {
            t0.Text = "1000";
            tK.Text = "0,001";
            sigma.Text = "0,9999";
            liczbaProb.Text = "1";
        }

        //wczytuje plik danych ze ścieżki + text na aktywnym przycisku
        private void wczytaj_Click(object sender, EventArgs e)
        {
            if (har.otworz(sciezka + a.Text + ".dat") != 1)
            {
                wczytajLED.BackColor = Color.Lime;
                wczytajLED.Text = a.Text;
                textBoxWczytano.Text = "Liczba zadan: "+har.liczbaZadan.ToString()+"\r\nLiczba maszyn: "+har.liczbaMaszyn.ToString();
                textBoxDlugoscNaturalna.Text = har.dlugoscNaturalna.ToString();
                textBoxHarmonogram.Text = har.wyswietl(har.harmonogram);
                optymalizuj.Enabled = true;
                reset.Enabled = true;
                btnGantt.Enabled = true;
                textBoxWynik.Clear();
            }
        }

        //zmienia aktywny przycisk
        private void wyborZestawu_MouseDown(object sender, MouseEventArgs e)
        {
            a = (Button)sender;
            label1.Visible = true;
        }

        //resetuje harmonogram aktualny do harmonogramu naturalnego
        private void reset_Click(object sender, EventArgs e)
        {
            har.reset();
            textBoxHarmonogram.Text = har.wyswietl(har.harmonogram);
            textBoxWynik.Clear();
        }

        //znajduje najlepszy harmonogram przy danych parametrach
        //nie pozwala na zmianę parametrów w trakcie pracy
        private void optymalizuj_Click(object sender, EventArgs e)
        {
            t0.Enabled = false;
            tK.Enabled = false;
            sigma.Enabled = false;
            liczbaProb.Enabled = false;
            optymalizuj.Enabled = false;
            reset.Enabled = false;

            try
            {
                har.optymalizuj(metoda, float.Parse(t0.Text), float.Parse(tK.Text), float.Parse(sigma.Text), long.Parse(liczbaProb.Text));
                textBoxHarmonogram.Text = har.wyswietl(har.harmonogram);
                textBoxWynik.Text = har.wynik.ToString();
            }
            catch
            {
                MessageBox.Show("Błędne parametry optymalizacji!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                resetParametrow();
            }

            t0.Enabled = true;
            tK.Enabled = true;
            sigma.Enabled = true;
            liczbaProb.Enabled = true;
            optymalizuj.Enabled = true;
            reset.Enabled = true;
        }

        //zmiana metody za pomocą radioButton
        private void radioButton_swap_CheckedChanged(object sender, EventArgs e)
        {
            metoda = 1;
        }
        private void radioButton_aswap_CheckedChanged(object sender, EventArgs e)
        {
            metoda = 2;
        }
        private void radioButton_ins_CheckedChanged(object sender, EventArgs e)
        {
            metoda = 3;
        }
        
        //kontrola działania przyciskami
        /*
         * spacja   - optymalizuj
         * Esc      - zamknij program
         * Ctrl + R - resetuj harmonogram
         * Ctrl + NumPadX   - wgraj dane z pliku X
        */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    this.Close();
                    return true;
                case Keys.Space:
                    optymalizuj.PerformClick();
                    return true;
                case Keys.Control | Keys.R:
                    reset.PerformClick();
                    return true;
                case Keys.Control | Keys.NumPad1:
                    a = button1;
                    a.PerformClick();
                    return true;
                case Keys.Control | Keys.NumPad2:
                    a = button2;
                    a.PerformClick();
                    return true;
                case Keys.Control | Keys.NumPad3:
                    a = button3;
                    a.PerformClick();
                    return true;
                case Keys.Control | Keys.NumPad4:
                    a = button4;
                    a.PerformClick();
                    return true;
                case Keys.Control | Keys.NumPad5:
                    a = button5;
                    a.PerformClick();
                    return true;
                case Keys.Control | Keys.NumPad6:
                    a = button6;
                    a.PerformClick();
                    return true;
                case Keys.Control | Keys.NumPad7:
                    a = button7;
                    a.PerformClick();
                    return true;
                case Keys.Control | Keys.NumPad8:
                    a = button8;
                    a.PerformClick();
                    return true;
                case Keys.Control | Keys.NumPad9:
                    a = button9;
                    a.PerformClick();
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }


        private void gantt_Click(object sender, EventArgs e)
        {
            har.liczGantta(wykres);
        }
    }
}
