using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Abbigliamento
{
    internal class clsPantaloni : clsIndumenti
    {
        private string tipo; // Jeans, Felpati, Leggins, Classici
        private uint taglia; // 44, 46, 48, 50, 52, 54, 56, 58, 60
        private string lunghezza; // Lunghi, Corti, Pinocchietti
        private string vestibilita; // Slim, Skinny

        public clsPantaloni(string marca, double prezzo, string colore, string materiale,
            string genere, string tipo, uint taglia, string lunghezza, string vestibilita)
            : base(marca, prezzo, colore, materiale, genere)
        {
            this.tipo = tipo;
            this.taglia = taglia;
            this.lunghezza = lunghezza;
            this.vestibilita = vestibilita;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public uint Taglia { get => taglia; set => taglia = value; }
        public string Lunghezza { get => lunghezza; set => lunghezza = value; }
        public string Vestibilita { get => vestibilita; set => vestibilita = value; }

        public override string ToString()
        {
            string stringaBase = base.ToString();
            return stringaBase + $" | Tipo: {tipo} | Taglia: {taglia} | Lunghezza: {lunghezza} | Vestibilità: {vestibilita}";
        }
    }
}
