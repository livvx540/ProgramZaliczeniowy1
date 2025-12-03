using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramZaliczeniowy1
{
    class Prezent
    {
        public string Imie { get; set; }
        public string Nazwa { get; set; }
        public decimal Cena { get; set; }

        public Prezent(string imie, string nazwa, decimal cena)
        {
            Imie = imie;
            Nazwa = nazwa;
            Cena = cena;
        }
        public override string ToString()
        {
            return $"{Imie} - {Nazwa} - {Cena} zł";
        }
    }
}
