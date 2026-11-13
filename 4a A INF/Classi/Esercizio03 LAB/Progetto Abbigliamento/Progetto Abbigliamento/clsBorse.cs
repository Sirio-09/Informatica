using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Abbigliamento
{
    internal class clsBorse : clsIndumenti
    {
        private string tipo; // Tracolla, Zainetto, Marsupio, Pochette
        private string taglia; // Piccola, Media, Grande
        private string stagione; // Invernale, Estivo

        public clsBorse(string marca, double prezzo, string colore, string materiale,
            string genere, string tipo, string taglia, string stagione)
            : base(marca, prezzo, colore, materiale, genere)
        {
            this.tipo = tipo;
            this.taglia = taglia;
            this.stagione = stagione;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Taglia { get => taglia; set => taglia = value; }
        public string Stagione { get => stagione; set => stagione = value; }

        public override string ToString()
        {
            string stringaBase = base.ToString();
            return stringaBase + $" | Tipo: {tipo} | Taglia: {taglia} | Stagione: {stagione}";
        }
    }
}
