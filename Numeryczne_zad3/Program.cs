using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeryczne_zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wtiaj. Podaj ścieżkę do pliku: ");
            string sciezka = Console.ReadLine();
            Macierz m = Odczyt.CzytajPlik(sciezka);
            Console.Write(m.WypiszMacierz());
            Console.ReadKey();
            
        }
    }
}
