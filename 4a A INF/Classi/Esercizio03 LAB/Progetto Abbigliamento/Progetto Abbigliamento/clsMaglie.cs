using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Progetto_Abbigliamento
{
    internal class clsMaglie : clsIndumenti
    {
        private string tipo; // Felpa, T-Shirt, Polo, Canotta
        private string taglia; // XS, S, M, L, XL, XXL, XXXL
        private string manica; // Lunga / Corta / MezzaManica / Smanicata
        private string apertura; // Zip, Bottoni, Velcro, Senza

        public clsMaglie(string marca, double prezzo, string colore, string materiale,
            string genere, string tipo, string taglia, string manica, string apertura)
            : base(marca, prezzo, colore, materiale, genere)
        {
            this.tipo = tipo;
            this.taglia = taglia;
            this.manica = manica;
            this.apertura = apertura;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public string Taglia { get => taglia; set => taglia = value; }
        public string Manica { get => manica; set => manica = value; }
        public string Apertura { get => apertura; set => apertura = value; }

        public override string ToString()
        {
            string stringaBase = base.ToString();
            return stringaBase + $" | Tipo: {tipo} | Taglia: {taglia} | Manica: {manica} | Apertura: {apertura}";
        }   
    }
}
