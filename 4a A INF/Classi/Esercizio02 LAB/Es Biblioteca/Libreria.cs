using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Biblioteca
{
    internal class Libreria
    {
        private List<Pubblicazione> catalogo = new List<Pubblicazione>();

        public Libreria()
        {
            catalogo = new List<Pubblicazione>();
        }

        internal List<Pubblicazione> Catalogo { get => catalogo; set => catalogo = value; }

        public void AggiungiPubblicazione(Pubblicazione p)
        {
            catalogo.Add(p);
        }

        public string VisualizzaCatalogo()
        {
            string res = "";
            foreach(var item in catalogo)
            {
                res += item.VisualizzaInfo() + "\n--------------";
            }

            return res;
        }

        public Pubblicazione CercaPerTitolo(string titolo)
        {
            foreach(var item in catalogo)
            {
                if(item.Titolo == titolo)
                {
                    return item;
                }
            }
            return null;
        }

        public double CalcolaPrezzoMedio()
        {
            double result = 0;
            if (catalogo.Count == 0) return 0;

            foreach(var item in catalogo)
            {
                result += item.Prezzo;
            }
            return result/catalogo.Count;
        }

        public List<Pubblicazione> OttieniLista()
        {
            return catalogo;
        }
    }
}
