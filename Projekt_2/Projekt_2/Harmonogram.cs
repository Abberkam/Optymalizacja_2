using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Projekt_2
{
    public class Harmonogram
    {
        private int _liczbaMaszyn;
        private int _liczbaZadan;
        private int _dlugoscNaturalna;
        private int _wynik;                 //najkrótsze za znalezionych Cmax
        private int[] harmonogramWynik;     //harmonogram o najktórszym Cmax z przeglądniętych
        private int[] harmonogramNat;       //[0,1,...,_liczbaZadań-1]     
        private int[][] bufor;              //przeliczane czasy
        private int[][] dane;               //czasy wykonania zadań[] na maszynach[]
        private Random rand;

        public int[] harmonogram;

        public int liczbaMaszyn { get { return _liczbaMaszyn; } set { _liczbaMaszyn = value; } }
        public int liczbaZadan { get { return _liczbaZadan; } set { _liczbaZadan = value; } }
        public int wynik { get { return _wynik; } set { _wynik = value; } }
        public int dlugoscNaturalna { get { return _dlugoscNaturalna; } set { _dlugoscNaturalna = value; } }

        //otwiera plik danych z podanej ścieżki, inicjalizuje wszystkie tablice i oblicza wynik
        public int otworz(string sciezka)
        {
            string[] data;
            StreamReader reader = new StreamReader(sciezka);
            string line;

            try
            {
                if ((line = reader.ReadLine()) != null)
                {
                    data = line.Split(' ');
                    liczbaZadan = Int32.Parse(data[0]);
                    liczbaMaszyn = Int32.Parse(data[1]);

                    dane = new int[liczbaZadan][];
                    for (int i = 0; i < liczbaZadan; i++)
                        dane[i] = new int[liczbaMaszyn];

                    bufor = new int[liczbaZadan + 1][];
                    for (int i = 0; i <= liczbaZadan; i++)
                        bufor[i] = new int[liczbaMaszyn + 1];
                    for (int i = 0; i <= liczbaZadan; i++)
                        for (int j = 0; j <= liczbaMaszyn; j++)
                            bufor[i][j] = 0;

                    harmonogram = new int[liczbaZadan];
                    for (int i = 0; i < liczbaZadan; i++)
                        harmonogram[i] = i;

                    harmonogramNat = new int[liczbaZadan];
                    harmonogram.CopyTo(harmonogramNat, 0);

                    harmonogramWynik = new int[liczbaZadan];
                    harmonogram.CopyTo(harmonogramWynik, 0);
                }
                for (int i = 0; i < liczbaZadan; i++)
                {
                    if ((line = reader.ReadLine()) != null)
                    {
                        data = line.Split(' ');
                        for (int j = 0; j < liczbaMaszyn; j++)
                        {
                            dane[i][j] = Int32.Parse(data[j]);
                        }
                    }
                }
                dlugoscNaturalna = liczDlugosc(harmonogramNat);
                wynik = liczDlugosc(harmonogramWynik);
                return 0;
            }
            catch
            {
                MessageBox.Show("Niepoprawna zawartość pliku", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
        }

        //resetuje aktualny harmonogram do harmonogramu natualnego
        public void reset()
        {
            harmonogramNat.CopyTo(harmonogram, 0);
        }
        
        //zwraca string utworzony z danego wektora w formacie "1 2 3 ... 9"
        public string wyswietl(int[] data)
        {
            string napis = "";
            foreach (int numer in data)
                napis += numer.ToString() + " ";
            napis += "\r\n";
            return napis;
        }

        //liczy parametr Cmax dla wektora
        private int liczDlugosc(int[] wektor)
        {
            int i, j;

            for (i = 1; i < liczbaZadan + 1; i++)
            {
                for (j = 1; j < liczbaMaszyn + 1; j++)
                {
                    bufor[i][j] = Math.Max(bufor[i - 1][j], bufor[i][j - 1]) + dane[wektor[i - 1]][j - 1];
                }
            }
            //using (StreamWriter writer = new StreamWriter("D:\\STUDIA\\SEMESTR 9 2014 - MGR\\OPTYMALIZACJA\\Optymalizacja_2\\bufor.txt", false))
            //{

            //    foreach (int[] row in bufor)
            //    {
            //        foreach (int num in row)
            //        {
            //            writer.Write(num);
            //            writer.Write(" ");
            //        }
            //        writer.Write("\r\n");
            //    }
            //}

            return bufor[liczbaZadan][liczbaMaszyn];
        }

        //wykonuje operasję SWAP na wektorze
        private void swap(int[] wektor)
        {
            rand = new Random();
            int x = rand.Next(0, liczbaZadan);
            int y = rand.Next(0, liczbaZadan);
            while (x == y) y = rand.Next(1, liczbaZadan);
            int tmp = wektor[x];
            wektor[x] = wektor[y];
            wektor[y] = tmp;
        }

        //wykonuje operasję ASWAP na wektorze
        private void aswap(int[] wektor)
        {
            rand = new Random();
            int x = rand.Next(0, liczbaZadan);
            int tmp = harmonogram[x];
            int y;
            if (x < liczbaZadan - 1 && x > 0)
            {
                if (rand.Next(2) == 0) y = x + 1;
                else y = x - 1;
            }
            else if (x == liczbaZadan - 1) y = x - 1;
            else if (x == 0) y = x + 1;
            else y = x;

            wektor[x] = wektor[y];
            wektor[y] = tmp;
        }

        //wykonuje operasję INS na wektorze
        private void ins(int[] wektor)
        {
            rand = new Random();
            int x = rand.Next(0, liczbaZadan);
            int y = rand.Next(0, liczbaZadan);
            while (x == y) y = rand.Next(0, liczbaZadan);
            int tmp;
            if (x > y)
            {
                tmp = x;
                x = y;
                y = tmp;
            }
            tmp = wektor[x];
            for (int i = x; i < y; i++)
                wektor[i] = wektor[i + 1];
            wektor[y] = tmp;
        }

        //wykorzystuje algorytm symulowanego wyżarzania do optymalizacji parametru Cmax
        //na końcu ustawia znaleziony najlepszy harmonogramWynik jako podstawowy harmonogram
        /*
         * metoda   - metoda zmiany kolejności zadań
         * t0       - temperatura początkowa
         * tK       - temperatura końcowa
         * sigma    - parametr obliczania spadku temperatury (t = t0 /( 1 + simga * t0)
         * liczbaProb   - liczba wywołanych kolejno algorytmów SA
        */
        public void optymalizuj(int metoda, float t0, float tK, float sigma, long liczbaProb)
        {
            int[] tmp = new int[harmonogram.Length];
            int[] tmpNajlepszy = new int[harmonogram.Length];

            int delta;
            double x, p;

            for (int i = 0; i < liczbaProb; i++)
            {
                harmonogram.CopyTo(tmpNajlepszy, 0);
                while(t0>tK)
                {
                    harmonogram.CopyTo(tmp, 0);
                    switch (metoda)
                    {
                        case 1:
                            swap(tmp);
                            break;
                        case 2:
                            aswap(tmp);
                            break;
                        case 3:
                            ins(tmp);
                            break;
                    }

                    delta = liczDlugosc(harmonogram) - liczDlugosc(tmp);

                    if (liczDlugosc(tmp) < liczDlugosc(tmpNajlepszy))
                    {
                        tmp.CopyTo(tmpNajlepszy, 0);
                        if (liczDlugosc(tmpNajlepszy) < wynik)
                        {
                            tmpNajlepszy.CopyTo(harmonogramWynik, 0);
                            wynik = liczDlugosc(harmonogramWynik);
                        }
                    }

                    if (delta >= 0)
                    {
                        tmp.CopyTo(harmonogram, 0);
                    }
                    else
                    {
                        x = rand.NextDouble();
                        p = Math.Exp(-delta / t0);
                        if (x < p)
                        {
                            tmp.CopyTo(harmonogram, 0);
                        }
                    }
                    t0 = t0 / (1 + sigma * t0);
                }
            }
            harmonogramWynik.CopyTo(harmonogram, 0);
        }
    }
}
