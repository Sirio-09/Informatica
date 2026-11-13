using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Abbigliamento
{
    internal class clsGiacche : clsIndumenti
    {
        private string tipologia; // Impermeabile, Piumino, Giacca, Kway, Giubbotto, Cappotto
        private string taglia; // XS, S, M, L, XL, XXL, XXXL
        private string stagione; // Invernale, Estivo, Primaverile

        public clsGiacche(string marca, double prezzo, string colore, string materiale,
            string genere, string tipologia, string taglia, string stagione)
            : base(marca, prezzo, colore, materiale, genere)
        {
            this.tipologia = tipologia;
            this.taglia = taglia;
            this.stagione = stagione;
        }

        public string Tipologia { get => tipologia; set => tipologia = value; }
        public string Taglia { get => taglia; set => taglia = value; }
        public string Stagione { get => stagione; set => stagione = value; }

        public override string ToString()
        {
            string stringaBase = base.ToString();
            return stringaBase + $" | Tipologia: {tipologia} | Taglia: {taglia} | Stagione: {stagione}";
        }
    }
}
