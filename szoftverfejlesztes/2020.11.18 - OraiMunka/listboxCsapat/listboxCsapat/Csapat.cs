using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listboxCsapat
{
    class Csapat
    {
        public string Nev { get; set; }
        public int Azonosito { get; set; }
        public DateTime SzulDat { get; set; }

        public Csapat(int id, string nev, DateTime szulDatum)
        {
            this.Azonosito = id;
            this.Nev = nev;
            this.SzulDat = szulDatum;
        }
    }
}
