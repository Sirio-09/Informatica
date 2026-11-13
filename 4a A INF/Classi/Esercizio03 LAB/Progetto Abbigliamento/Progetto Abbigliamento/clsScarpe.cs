using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Abbigliamento
{
    internal class clsScarpe : clsIndumenti
    {
        private string tipologia; // Sandali, Da Ginnastica, Mocassini, Stivali, Ciabatte
        private uint numero; // 18 .. 50
        private string apertura; // Lacci, Velcro, Zip, Aperte
        private string suola; // Cuoio, Gomma, Plastica, Legno

        public clsScarpe(string marca, double prezzo, string colore, string materiale,
            string genere, string tipologia, uint numero, string apertura, string suola)
            : base(marca, prezzo, colore, materiale, genere)
        {
            this.tipologia = tipologia;
            this.numero = numero;
            this.apertura = apertura;
            this.suola = suola;
        }

        public string Tipologia { get => tipologia; set => tipologia = value; }
        public uint Numero { get => numero; set => numero = value; }
        public string Apertura { get => apertura; set => apertura = value; }
        public string Suola { get => suola; set => suola = value; }

        public override string ToString()
        {
            string stringaBase = base.ToString();
            return stringaBase + $" | Tipologia: {tipologia} | Numero: {numero} | Apertura: {apertura} | Suola: {suola}";
        }
    }
}
