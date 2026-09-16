using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_12_Pag_115
    {
        internal class Program
        {
            static string[] titoli = {
            "Il nome della rosa", "1984", "Il signore degli anelli",
            "Harry Potter e la pietra filosofale", "Il piccolo principe",
            "La coscienza di Zeno", "Il codice Da Vinci",
            "Orgoglio e pregiudizio", "I promessi sposi", "Fahrenheit 451"
        };

            static string[] generi = {
            "Giallo storico", "Fantascienza", "Fantasy",
            "Fantasy", "Narrativa", "Narrativa",
            "Thriller", "Romanzo", "Romanzo storico", "Fantascienza"
        };

            static string[] caseEditrici = {
            "Bompiani", "Mondadori", "Bompiani",
            "Salani", "Bompiani", "Newton Compton",
            "Mondadori", "Feltrinelli", "Garzanti", "Mondadori"
        };

        private static int ContaLibri(string genere, string editore)
        {
            int contatore = 0;

            for (int i = 0; i < titoli.Length; i++)
            {
                if (generi[i] == genere && caseEditrici[i] == editore)
                {
                    contatore++;
                    Console.WriteLine($"Trovato: {titoli[i]}");
                }
            }
            return contatore;
        }

        static void Main(string[] args)
            {
                Console.Write("Inserisci il genere (es. Fantasy, Fantascienza): ");
                string genereUtente = Console.ReadLine();

                Console.Write("Inserisci la casa editrice (es. Mondadori, Bompiani): ");
                string editoreUtente = Console.ReadLine();

                int numeroLibri = ContaLibri(genereUtente, editoreUtente);

                if (numeroLibri > 0)
                {
                    Console.WriteLine($"Risultato: Trovati {numeroLibri} libri corrispondenti.");
                }
                else
                {
                    Console.WriteLine("Nessun libro trovato con i criteri inseriti.");
                }
                Console.ReadKey();
            }

        }
    }
