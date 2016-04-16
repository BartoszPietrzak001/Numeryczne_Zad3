using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeryczne_zad3
{
    public class Macierz
    {
        public double[,] tab { get; set; }
        public int wiersz { get; set; }
        public int kolumna { get; set; }
        public double zero = 0.00000001;

        public Macierz(int wiersz, int kolumna)
        {
            this.wiersz = wiersz;
            this.kolumna = kolumna;
            this.tab = new double[wiersz, kolumna];
        }

        public string WypiszMacierz()
        {
            string data = "";
            for (int i = 0; i < wiersz; i++)
            {
                for (int j = 0; j < kolumna; j++)
                {
                    data += string.Format("{0,-7}", Math.Round(tab[i, j], 4)) + " ";
                }
                data += "\n";
            }
            return data;
        }

        public string Interpolacja()
        {
            int stopien = kolumna / 2;

            double n = tab[2, 0];

            for (int i = 0; i < kolumna; i++)
            {
                tab[0, i] = tab[0, 1] * 2 * Math.PI;
            }
            double[] A = new double[stopien + 1];
            double[] B = new double[stopien + 1];

            for (int i = 0; i < kolumna-1; i++)
            {
                A[i] = 2 /n;
                for (int j = 0; j < n-1 ; j++)
                {

                }
            }
            return "chuj";
        }


    }
}
