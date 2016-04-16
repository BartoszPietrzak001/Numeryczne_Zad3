using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Numeryczne_zad3
{
    class Odczyt
    {
        public static Macierz CzytajPlik(string sciezka)
        {
            StreamReader sr = new StreamReader(sciezka);

            string file = sr.ReadToEnd();
            string[] lines = file.Split('\n');
            string[] parts = lines[0].Split(' ');
            double[,] wspolczynniki = new double[lines.Length, parts.Length];
            int pindol = parts.Length;

            for (int i=0; i < lines.Length; i++)
            {
                parts = lines[i].Split(' ');
                
                for (int j=0; j<parts.Length; j++)
                {
                    wspolczynniki[i, j] = double.Parse(parts[j]);
                }
            }

            sr.Close();

            Macierz macierz = new Macierz(lines.Length, pindol);

            for (int i=0; i<macierz.wiersz; i++)
            {
                for (int j=0; j<macierz.kolumna; j++)
                {
                    macierz.tab[i, j] = wspolczynniki[i, j];
                }
            }

            return macierz;
        }

    }
}
