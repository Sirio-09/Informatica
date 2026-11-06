using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Biblioteca
{
    internal class Rivista : Pubblicazione
    {
        private int numeroEdizione;

        public Rivista(string titolo, string autore, double prezzo, int NumeroEdizione)
            : base(titolo, autore, prezzo)
        {
            numeroEdizione = NumeroEdizione;
        }

        public int NumeroEdizione { get => numeroEdizione; set => numeroEdizione = value; }

        public override string VisualizzaInfo()
        {
            string _base = base.VisualizzaInfo();
            return $"{_base}\nNumero Edizione: {numeroEdizione}";
        }
    }
}
