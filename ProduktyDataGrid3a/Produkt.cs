using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduktyDataGrid3a
{
    internal class Produkt
    {
        public string nazwa { get; set; }
        public int cena { get; set; }
        public bool dostepnosc { get; set; }
        public string kategoria { get; set; }

        public Produkt(string nazwa, int cena, bool dostepnosc, string kategoria)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.dostepnosc = dostepnosc;
            this.kategoria = kategoria;
        }
        public override string ToString()
        {
            return nazwa + " " + kategoria;
        }
    }
}
