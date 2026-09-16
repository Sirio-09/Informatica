using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_1_Es_1
{
    public class Persona
    {
        private string nome;
        private string cognome;
        private int eta;

        public Persona(string nome, string cognome, int eta)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Eta = eta;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }

        public int Eta
        {
            get { return eta; }
            set
            {
                if (value > 0)
                    eta = value;
                else
                    Console.WriteLine("Errore: l'età deve essere maggiore di 0.");
            }
        }

        public void StampaDati()
        {
            Console.WriteLine($"Nome: {Nome}  |  Cognome: {Cognome}  |  Età: {Eta}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("ESERCIZIO 1.1");

            Persona persona1 = new Persona("Mario", "Rossi", 25);
            Persona persona2 = new Persona("Laura", "Bianchi", 30);

            persona1.StampaDati();
            persona2.StampaDati();

            Console.WriteLine();
            Console.WriteLine("ESERCIZIO 1.3");

            Console.WriteLine("Modifica Nome e Età di persona1...");
            persona1.Nome = "Giovanni";
            persona1.Eta = 35;
            persona1.StampaDati();

            Console.WriteLine();
            Console.WriteLine("Tentativo di impostare un'età negativa (-5):");
            persona1.Eta = -5;

            Console.WriteLine();
            Console.WriteLine("Tentativo di impostare età = 0:");
            persona1.Eta = 0;

            Console.ReadKey();
        }
    }
}
