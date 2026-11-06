using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Es_Biblioteca
{
    internal class Libro : Pubblicazione
    {
        private int NumeroPagine;

        public Libro(string titolo, string autore, double prezzo, int numeroPagine)
            : base(titolo, autore, prezzo)
        {
            NumeroPagine = numeroPagine;
        }

        public int NumeroPagine1 { get => NumeroPagine; set => NumeroPagine = value; }

        public override string VisualizzaInfo()
        {
            string _base = base.VisualizzaInfo();
            return $"{_base}\nNumero Pagine: {NumeroPagine}";
        }
    }
}
