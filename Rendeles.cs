using System;
using System.Collections.Generic;
using System.Text;

namespace PizzeriaRendeles
{
    public class Rendeles
    {
        public string VevoNev { get; set; }
        public int PizzakSzama { get; set; }
        public int TavolsagKm { get; set; }

        public Rendeles(string sor)
        {
            string[] darabolt = sor.Split(';');
            VevoNev = darabolt[0];
            PizzakSzama = int.Parse(darabolt[1]);
            TavolsagKm = int.Parse(darabolt[2]);
        }

        public int FizetendoDij()
        {

            return 2500 * PizzakSzama + 300 * TavolsagKm;
        }

        public override string ToString()
        {
            return $"{VevoNev}: {PizzakSzama} db pizza, {TavolsagKm} km - Fizetendő: {FizetendoDij()} Ft";
        }
    }
}
