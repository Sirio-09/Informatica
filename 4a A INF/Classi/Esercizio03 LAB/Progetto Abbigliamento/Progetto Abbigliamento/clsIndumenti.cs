using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto_Abbigliamento
{
    internal class clsIndumenti
    {
        private string marca; // Chi Produce
        private double prezzo; // € Euro
        private string colore; // Rosso, Verde, Blu, Rosa
        private string materiale; // Con che Cosa è Fatto
        private string genere; // Uomo/Donna/Bambino/Bambina

        public clsIndumenti(string marca, double prezzo, string colore, string materiale, string genere)
        {
            this.marca = marca;
            this.prezzo = prezzo;
            this.colore = colore;
            this.materiale = materiale;
            this.genere = genere;
        }

        public string Marca { get => marca; set => marca = value; }
        public double Prezzo { get => prezzo; set => prezzo = value; }
        public string Colore { get => colore; set => colore = value; }
        public string Materiale { get => materiale; set => materiale = value; }
        public string Genere { get => genere; set => genere = value; }

        public override string ToString()
        {
            return $"Marca: {marca} | Prezzo: {prezzo} | Colore: {colore} | Materiale: {materiale} | Genere: {genere}";
        }
    }
}
