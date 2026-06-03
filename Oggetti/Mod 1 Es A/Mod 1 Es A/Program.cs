using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_1_Es_A
{
    internal class Program
    {
        public class Persona
        {
            private string nome;
            private string cognome;
            private int eta;
            private string indirizzo;

            public Persona(string nome, string cognome, int eta, string indirizzo = "")
            {
                this.Nome = nome;
                this.Cognome = cognome;
                this.Eta = eta;
                this.Indirizzo = indirizzo;
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

            public string Indirizzo
            {
                get { return indirizzo; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                        Console.WriteLine("Errore: l'indirizzo non può essere vuoto o null.");
                    else
                        indirizzo = value;
                }
            }

            public void StampaDati()
            {
                Console.WriteLine($"Nome: {Nome}  |  Cognome: {Cognome}  |  " +
                                  $"Età: {Eta}  |  Indirizzo: {Indirizzo}");
            }

            static void Main(string[] args)
            {

                Persona p1 = new Persona("Mario", "Rossi", 25, "Via Roma 1, Milano");
                Persona p2 = new Persona("Laura", "Bianchi", 30);

                p1.StampaDati();
                p2.StampaDati();

                Console.WriteLine();
                Console.WriteLine("Provo a impostare un indirizzo valido per p2:");
                p2.Indirizzo = "Corso Vittorio 5, Torino";
                p2.StampaDati();

                Console.WriteLine();
                Console.WriteLine("Provo a impostare un indirizzo vuoto: ");
                p2.Indirizzo = "";
                p2.Indirizzo = "   ";
                Console.WriteLine($"Indirizzo rimasto: {p2.Indirizzo}");

                Console.ReadKey();
            }
        }
    }
}
