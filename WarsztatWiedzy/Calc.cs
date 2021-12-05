using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_1
{
    internal class Calc
    {
        public int Dodaj(string liczbaATeksotowo, string liczbaBTeksotowo)
        {
            var wynikParsowania = int.TryParse(liczbaATeksotowo, out int liczbaA);
            if (!wynikParsowania)
                Console.WriteLine("Miales  podac liczbe");

            wynikParsowania = int.TryParse(liczbaBTeksotowo, out int liczbaB);
            if (!wynikParsowania)
                Console.WriteLine("Miales  podac liczbe");

            int wynik = liczbaA + liczbaB;
            return wynik;
        }

        public int Odejmij()
        {
            return 0;
        }
    }
}
