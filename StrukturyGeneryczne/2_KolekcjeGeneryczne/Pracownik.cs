using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    public class Pracownik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public Pracownik() { }
        public Pracownik(string im, string na)
        {
            this.Imie = im;
            this.Nazwisko = na;
        }
    }
}
