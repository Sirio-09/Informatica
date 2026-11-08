using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Biblioteca
{
    internal class Pubblicazione
    {
        private string titolo;
        private string autore;
        private double prezzo;

        public Pubblicazione(string Titolo, string Autore, double Prezzo)
        {
            titolo = Titolo;
            autore = Autore;
            prezzo = Prezzo;
        }

        public string Titolo { get => titolo; set => titolo = value; }
        public string Autore { get => autore; set => autore = value; }
        public double Prezzo { get => prezzo; set => prezzo = value; }

        public virtual string VisualizzaInfo()
        {
            return $"Titolo: {Titolo}\nAutore: {Autore}\nPrezzo: {Prezzo}";
        } 
    }
}
